namespace WF_DZ7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            currentTabToolStripMenuItem = new ToolStripMenuItem();
            newTabToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            currentTabToolStripMenuItem1 = new ToolStripMenuItem();
            newTabToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            recentToolStripMenuItem = new ToolStripMenuItem();
            closeTabToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            fontscolorToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            scaleToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            closeTabToolStripMenuItem1 = new ToolStripMenuItem();
            newThisTabToolStripMenuItem = new ToolStripMenuItem();
            openThisTabToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, recentToolStripMenuItem, closeTabToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentTabToolStripMenuItem, newTabToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(195, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // currentTabToolStripMenuItem
            // 
            currentTabToolStripMenuItem.Name = "currentTabToolStripMenuItem";
            currentTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            currentTabToolStripMenuItem.Size = new Size(209, 22);
            currentTabToolStripMenuItem.Text = "&Current tab";
            currentTabToolStripMenuItem.Click += NewCurrentTabToolStripMenuItem_Click;
            // 
            // newTabToolStripMenuItem
            // 
            newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            newTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newTabToolStripMenuItem.Size = new Size(209, 22);
            newTabToolStripMenuItem.Text = "&New tab";
            newTabToolStripMenuItem.Click += newTabToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentTabToolStripMenuItem1, newTabToolStripMenuItem1 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(195, 22);
            openToolStripMenuItem.Text = "&Open...";
            // 
            // currentTabToolStripMenuItem1
            // 
            currentTabToolStripMenuItem1.Name = "currentTabToolStripMenuItem1";
            currentTabToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            currentTabToolStripMenuItem1.Size = new Size(210, 22);
            currentTabToolStripMenuItem1.Text = "&Current Tab";
            currentTabToolStripMenuItem1.Click += OpenCurrentTabToolStripMenuItem1_Click;
            // 
            // newTabToolStripMenuItem1
            // 
            newTabToolStripMenuItem1.Name = "newTabToolStripMenuItem1";
            newTabToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            newTabToolStripMenuItem1.Size = new Size(210, 22);
            newTabToolStripMenuItem1.Text = "&New Tab";
            newTabToolStripMenuItem1.Click += OpenNewTabToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(195, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save &As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // recentToolStripMenuItem
            // 
            recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            recentToolStripMenuItem.Size = new Size(195, 22);
            recentToolStripMenuItem.Text = "Recent";
            // 
            // closeTabToolStripMenuItem
            // 
            closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            closeTabToolStripMenuItem.Size = new Size(195, 22);
            closeTabToolStripMenuItem.Text = "&Close tab";
            closeTabToolStripMenuItem.Click += closeTabToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, findToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(174, 22);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            redoToolStripMenuItem.Size = new Size(174, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(174, 22);
            cutToolStripMenuItem.Text = "C&ut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(174, 22);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(174, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(174, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new Size(174, 22);
            findToolStripMenuItem.Text = "&Find";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontsToolStripMenuItem, fontscolorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "For&mat";
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(142, 22);
            fontsToolStripMenuItem.Text = "F&onts...";
            fontsToolStripMenuItem.Click += fontsToolStripMenuItem_Click;
            // 
            // fontscolorToolStripMenuItem
            // 
            fontscolorToolStripMenuItem.Name = "fontscolorToolStripMenuItem";
            fontscolorToolStripMenuItem.Size = new Size(142, 22);
            fontscolorToolStripMenuItem.Text = "Fonts &color...";
            fontscolorToolStripMenuItem.Click += fontscolorToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scaleToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // scaleToolStripMenuItem
            // 
            scaleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem });
            scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            scaleToolStripMenuItem.Size = new Size(101, 22);
            scaleToolStripMenuItem.Text = "&Scale";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new Size(222, 22);
            zoomInToolStripMenuItem.Text = "Zoom &In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new Size(222, 22);
            zoomOutToolStripMenuItem.Text = "Zoom &Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(89, 17);
            toolStripStatusLabel1.Text = "Symbol in text: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(92, 17);
            toolStripStatusLabel2.Text = "file is not saving";
            // 
            // tabControl1
            // 
            tabControl1.ContextMenuStrip = contextMenuStrip1;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 404);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newThisTabToolStripMenuItem, openThisTabToolStripMenuItem, closeTabToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 92);
            // 
            // closeTabToolStripMenuItem1
            // 
            closeTabToolStripMenuItem1.Name = "closeTabToolStripMenuItem1";
            closeTabToolStripMenuItem1.Size = new Size(180, 22);
            closeTabToolStripMenuItem1.Text = "&Close Tab";
            closeTabToolStripMenuItem1.Click += closeTabToolStripMenuItem_Click;
            // 
            // newThisTabToolStripMenuItem
            // 
            newThisTabToolStripMenuItem.Name = "newThisTabToolStripMenuItem";
            newThisTabToolStripMenuItem.Size = new Size(180, 22);
            newThisTabToolStripMenuItem.Text = "&New this Tab";
            newThisTabToolStripMenuItem.Click += NewCurrentTabToolStripMenuItem_Click;
            // 
            // openThisTabToolStripMenuItem
            // 
            openThisTabToolStripMenuItem.Name = "openThisTabToolStripMenuItem";
            openThisTabToolStripMenuItem.Size = new Size(180, 22);
            openThisTabToolStripMenuItem.Text = "&Open this Tab";
            openThisTabToolStripMenuItem.Click += OpenCurrentTabToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NoteBookPRO";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem recentToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem fontscolorToolStripMenuItem;
        private ToolStripMenuItem currentTabToolStripMenuItem;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolStripMenuItem currentTabToolStripMenuItem1;
        private ToolStripMenuItem newTabToolStripMenuItem1;
        private ToolStripMenuItem closeTabToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem scaleToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeTabToolStripMenuItem1;
        private ToolStripMenuItem newThisTabToolStripMenuItem;
        private ToolStripMenuItem openThisTabToolStripMenuItem;
    }
}
