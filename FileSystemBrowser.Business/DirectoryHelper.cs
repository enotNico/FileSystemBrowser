using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FileSystemBrowser.Data.Interfaces;
using FileSystemBrowser.Data.Repositories;
using System.IO;

namespace FileSystemBrowser.Business
{
    public class DirectoryHelper
    {
        IRepository<DirectoryInfo> directories = null;

        public DirectoryHelper(string currentPath)
        {
            directories = new DirectoryRepository(currentPath);
        }
    }
}