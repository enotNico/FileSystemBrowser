using System;
using System.Collections.Generic;
using System.IO;

using FileSystemBrowser.Data.Interfaces;

namespace FileSystemBrowser.Data.Repositories
{
    public class FIleRepository : IRepository<FileInfo>
    {
        public IEnumerable<FileInfo> Get(string path)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileInfo> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
