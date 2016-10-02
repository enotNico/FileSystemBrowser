using System;
using System.Collections.Generic;
using System.IO;

using FileSystemBrowser.Data.Interfaces;

namespace FileSystemBrowser.Data.Repositories
{
    public class DriveRepository : IRepository<DriveInfo>
    {
        public IEnumerable<DriveInfo> Get(string path)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DriveInfo> GetAll()
        {
            return DriveInfo.GetDrives();
        }
    }
}
