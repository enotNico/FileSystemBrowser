using System;
using System.Collections.Generic;
using System.IO;

using FileSystemBrowser.Data.Interfaces;

namespace FileSystemBrowser.Data.Repositories
{
    public class DriveRepository
    {
        public IEnumerable<DriveInfo> GetAll()
        {
            return DriveInfo.GetDrives();
        }
    }
}
