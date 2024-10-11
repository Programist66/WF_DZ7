using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ7
{
    public class PageInfo
    {
        public bool isTextChanged;
        public string? fileName = null;

        public PageInfo(bool isTextChanged, string? fileName)
        {
            this.isTextChanged = isTextChanged;
            this.fileName = fileName;
        }

        public override string ToString() 
        {
            return fileName;
        }
    }
}
