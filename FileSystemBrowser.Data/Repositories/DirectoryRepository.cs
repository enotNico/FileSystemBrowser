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
            IEnumerable<DirectoryInfo> currentDirectories = null;
            try
            {
                currentDirectories = directory.GetDirectories();
            }
            catch (Exception) { }

            return currentDirectories;
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            IEnumerable<FileInfo> currentFiles = null;

            try
            {
               currentFiles = directory.GetFiles();
            } catch(Exception) { }

            return currentFiles;
        }

    }
}
