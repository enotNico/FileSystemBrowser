using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using FileSystemBrowser.Data.Interfaces;

namespace FileSystemBrowser.Data.Repositories
{
    public class DirectoryRepository
    {
        private DirectoryInfo directory = null;

        public DirectoryRepository(string currentPath)
        {
            directory = new DirectoryInfo(currentPath);
        }

        public IEnumerable<DirectoryInfo> GetDirectories()
        {
            return directory.GetDirectories();
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            return directory.GetFiles();
        }

    }
}
