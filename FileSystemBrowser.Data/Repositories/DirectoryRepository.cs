using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using FileSystemBrowser.Data.Interfaces;

namespace FileSystemBrowser.Data.Repositories
{
    public class DirectoryRepository : IRepository<DirectoryInfo>
    {
        string currentPath = "";

        public DirectoryRepository(string currentPath)
        {
            this.currentPath = currentPath;
        }

        public IEnumerable<DirectoryInfo> Get(string path)
        {
            return new List<DirectoryInfo>();
        }

        public IEnumerable<DirectoryInfo> GetSubDirectories(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetDirectories();
        }

        public IEnumerable<FileInfo> GetFiles(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetFiles();
        }

        public IEnumerable<DirectoryInfo> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
