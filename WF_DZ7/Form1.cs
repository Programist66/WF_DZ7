using System.IO;
using System.Windows.Forms;

namespace WF_DZ7
{
    public partial class Form1 : Form
    {
        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();
        const string empteFile = "Untitled";
        const string pathToRecentFile = @"E:\ÿ¿√\WindowsForms\WF_DZ7\WF_DZ7\bin\Debug\net8.0-windows\Recents.txt";
        const int countVisibleRecentFiles = 10;
        private float currentZoomFactor = 1.0f;
        private const float ZOOM_STEP = 1.1f;

        public Form1()
        {
            InitializeComponent();
            AddPages();
            UpdateRecentFiles();
            UpdateStatusBar();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPages();
        }

        private void AddPages(string? path = null)
        {
            TabPage tabPage = new TabPage();
            tabPage.Padding = new Padding(3);
            tabControl1.TabPages.Add(tabPage);
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            tabPage.Controls.Add(textBox);
            textBox.Dock = DockStyle.Fill;
            EditCurrentTab(tabPage, path);
            textBox.TextChanged += TextBoxTextChanged;
        }

        private void Save(TabPage? currentPage = null)
        {
            if (currentPage is null)
            {
                currentPage = tabControl1.SelectedTab;
                if (currentPage == null)
                {
                    return;
                }
            }
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            if (currentPageInfo?.fileName == null)
            {
                SaveAs(currentPage);
            }
            else
            {
                File.WriteAllText(currentPageInfo.fileName, ((TextBox)currentPage.Controls[0]).Text);
                currentPageInfo.isTextChanged = false;
                currentPage.Tag = currentPageInfo;
                AddRecentFile(currentPageInfo.fileName);
                UpdateStatusBar();
            }
        }

        private void SaveAs(TabPage? currentPage = null)
        {
            if (currentPage is null)
            {
                currentPage = tabControl1.SelectedTab;
                if (currentPage == null)
                {
                    return;
                }
            }
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Title = "Choise a file";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            File.WriteAllText(dialog.FileName, ((TextBox)currentPage.Controls[0]).Text);
            currentPageInfo.fileName = dialog.FileName;
            currentPageInfo.isTextChanged = false;
            currentPage.Tag = currentPageInfo;
            currentPage.Text = Path.GetFileName(dialog.FileName);
            AddRecentFile(dialog.FileName);
            UpdateStatusBar();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        private void CloseTab(TabPage? currentPage = null)
        {
            if (currentPage is null)
            {
                currentPage = tabControl1.SelectedTab;
                if (currentPage == null)
                {
                    return;
                }
            }
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            bool isSaveEnded = true;
            if (currentPageInfo.isTextChanged)
            {
                isSaveEnded = SaveChangetText(currentPage, currentPageInfo);
            }
            if (isSaveEnded)
            {
                currentPage.Dispose();
            }
            UpdateStatusBar();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            TabPage? currentPage = tabControl1.SelectedTab;
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            currentPageInfo.isTextChanged = true;
            undoStack.Push(currentPage.Controls[0].Text);
            UpdateStatusBar();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void NewCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isSaveEnded = true;
            TabPage? currentPage = tabControl1.SelectedTab;
            if (currentPage == null)
            {
                return;
            }
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            if (currentPageInfo.isTextChanged)
            {
                isSaveEnded = SaveChangetText(currentPage, currentPageInfo);
            }
            if (isSaveEnded)
            {
                EditCurrentTab(currentPage);
            }
        }
        private bool SaveChangetText(TabPage currentPage, PageInfo pageInfo)
        {
            DialogResult result = MessageBox.Show("Save changed?", "Saves", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (pageInfo.fileName is null)
                {
                    SaveAs(currentPage);
                }
                else
                {
                    Save(currentPage);
                }
                return true;
            }
            else if (result == DialogResult.No)
            {
                return true;
            }
            return false;
        }

        private void EditCurrentTab(TabPage currentPage, string? path = null)
        {
            if (path is null)
            {
                currentPage.Controls[0].Text = "";
                currentPage.Tag = new PageInfo(false, null);
                currentPage.Text = empteFile;
            }
            else
            {
                currentPage.Controls[0].Text = File.ReadAllText(path);
                currentPage.Tag = new PageInfo(false, path);
                currentPage.Text = Path.GetFileName(path);
            }
            UpdateStatusBar();
        }

        private void OpenCurrentTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isSaveEnded = true;
            TabPage? currentPage = tabControl1.SelectedTab;
            if (currentPage == null)
            {
                return;
            }
            PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
            if (currentPageInfo.isTextChanged)
            {
                isSaveEnded = SaveChangetText(currentPage, currentPageInfo);
            }
            if (isSaveEnded)
            {
                using OpenFileDialog dialog = new();
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.Title = "Choise a file";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                EditCurrentTab(currentPage, dialog.FileName);
                AddRecentFile(dialog.FileName);
            }
        }

        private void OpenNewTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Title = "Choise a file";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            AddPages(dialog.FileName);
            AddRecentFile(dialog.FileName);
        }

        private void UpdateRecentFiles()
        {
            using StreamReader reader = File.OpenText(pathToRecentFile);
            recentToolStripMenuItem.DropDownItems.Clear();

            string?[] files = new string[countVisibleRecentFiles];
            for (int i = 0; i < countVisibleRecentFiles; i++)
            {
                string? file = reader?.ReadLine();
                files[i] = file;
            }
            foreach (var file in files)
            {
                if (file is not null)
                {
                    ToolStripMenuItem fileStrip = new ToolStripMenuItem(Path.GetFileName(file));
                    fileStrip.Tag = file;
                    fileStrip.Click += OpenRecentFiles;
                    recentToolStripMenuItem.DropDownItems.Add(fileStrip);
                }
            }
        }

        private void OpenRecentFiles(object? sender, EventArgs e)
        {
            ToolStripMenuItem? file = sender as ToolStripMenuItem;
            AddPages(file.Tag.ToString());
        }

        private void AddRecentFile(string path)
        {
            List<string> files = new();
            files.AddRange(File.ReadAllLines(pathToRecentFile));
            files = files.Where(f => f != path).ToList();
            files.Insert(0, path);
            using (StreamWriter writer = new StreamWriter(pathToRecentFile, false))
            {
                foreach (string file in files)
                {
                    writer.WriteLine(file);
                }
            };
            UpdateRecentFiles();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                TabPage currentPage = tabControl1.SelectedTab;
                int cursor_pos = (currentPage.Controls[0] as TextBox).SelectionStart;
                redoStack.Push(undoStack.Pop());
                currentPage.Controls[0].Text = undoStack.Peek();
                (currentPage.Controls[0] as TextBox).Select(currentPage.Controls[0].Text.Length, 0);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                TabPage currentPage = tabControl1.SelectedTab;
                int cursor_pos = (currentPage.Controls[0] as TextBox).SelectionStart;
                undoStack.Push(currentPage.Controls[0].Text);
                currentPage.Controls[0].Text = redoStack.Pop();
                (currentPage.Controls[0] as TextBox).Select(currentPage.Controls[0].Text.Length, 0);
            }
        }

        private void UpdateZoomFactor()
        {
            TabPage currentPage = tabControl1.SelectedTab;
            currentZoomFactor = Math.Max(0.01f, Math.Min(100.0f, currentZoomFactor));
            TextBox textBox = currentPage.Controls[0] as TextBox;
            textBox.Font = new Font(textBox.Font.FontFamily, 12.0f * currentZoomFactor, textBox.Font.Style);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentZoomFactor *= ZOOM_STEP;
            UpdateZoomFactor();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentZoomFactor /= ZOOM_STEP;
            UpdateZoomFactor();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;

            int selStart = textBox.SelectionStart;
            int selLength = textBox.SelectionLength;

            string start = textBox.Text.Substring(0, selStart);
            string middle = Clipboard.ContainsText() ? Clipboard.GetText() : textBox.SelectedText;
            string end = textBox.Text.Substring(selStart + selLength);

            textBox.Text = $"{start}{middle}{end}";
            textBox.Select(selStart + middle.Length, 0);
            undoStack.Push(textBox.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;

            if (textBox.SelectedText.Length > 0)
            {
                Clipboard.SetText(textBox.SelectedText);
            }

            int selStart = textBox.SelectionStart;
            int selLength = textBox.SelectionLength;

            string start = textBox.Text.Substring(0, selStart);
            string end = textBox.Text.Substring(selStart + selLength);

            textBox.Text = $"{start}{end}";
            textBox.Select(selStart, 0);
            undoStack.Push(textBox.Text);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;

            if (textBox.SelectedText.Length > 0)
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;
            int selStart = textBox.SelectionStart;
            int selLength = textBox.SelectionLength;

            string start = textBox.Text.Substring(0, selStart);
            string end = textBox.Text.Substring(selStart + (selLength != 0 ? selLength : textBox.Text.Length - selStart > 0 ? 1 : 0));

            textBox.Text = $"{start}{end}";
            textBox.Select(selStart, 0);
            undoStack.Push(textBox.Text);
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;
            using FontDialog dialogFont = new();

            if (dialogFont.ShowDialog() != DialogResult.OK) return;

            textBox.Font = dialogFont.Font;
        }

        private void fontscolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl1.SelectedTab;
            TextBox textBox = currentPage.Controls[0] as TextBox;
            using ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() != DialogResult.OK) return;
            textBox.ForeColor = colorDialog.Color;
        }

        private void UpdateStatusBar()
        {
            TabPage? currentPage = tabControl1.SelectedTab;
            if (currentPage == null)
            {
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
            }
            else
            {
                PageInfo? currentPageInfo = currentPage.Tag as PageInfo;
                toolStripStatusLabel1.Text = $"Symbol in text: {currentPage.Controls[0].Text.Length}";
                toolStripStatusLabel2.Text = currentPageInfo.isTextChanged ? "File not saved" : "File saved";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }
    }
}
