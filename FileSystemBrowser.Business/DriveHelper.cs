using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using FileSystemBrowser.Data.Interfaces;
using FileSystemBrowser.Data.Repositories;

namespace FileSystemBrowser.Business
{
    public class DriveHelper
    {
        DriveRepository Drives = new DriveRepository();

        public IEnumerable<DriveInfo> GetDrives()
        {
            return Drives.GetAll();
        }
    }
}
