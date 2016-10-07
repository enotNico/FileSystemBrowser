using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemBrowser.Business
{
    public class FileSizesHelper
    {
        private string path = "";

        public FileSizesHelper(string currentPath)
        {
            this.path = currentPath;
        }

        public int[] GetFileSizes()
        {
            return Services.CountFileSizes.GetCount(path);
        }
    }
}
