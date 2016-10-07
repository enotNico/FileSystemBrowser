using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FileSystemBrowser.Data.Repositories;
using System.IO;

namespace FileSystemBrowser.Business
{
    public class DirectoryHelper
    {
        DirectoryRepository directories = null;

        public DirectoryHelper(string currentPath)
        {
            directories = new DirectoryRepository(currentPath);
        }

        public IEnumerable<DirectoryInfo> GetDirectories()
        {
            return directories.GetDirectories();
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            return directories.GetFiles();
        }
    }
}