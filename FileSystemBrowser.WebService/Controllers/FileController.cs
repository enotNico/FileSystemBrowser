using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using FileSystemBrowser.Business;
using System.IO;

namespace FileSystemBrowser.WebService.Controllers
{
    public class FileController : ApiController
    {
        DirectoryHelper directoryHepler = null;
        DriveHelper driveHelper = new DriveHelper();
        
        public IEnumerable<FileInfo> Get()
        {
            directoryHepler = new DirectoryHelper(driveHelper.GetDrives().FirstOrDefault().Name);
            return directoryHepler.GetFiles();
        }

        //GET: api/Directory/5
        public IEnumerable<FileInfo> Get([FromUri]string path)
        {
            directoryHepler = new DirectoryHelper(path);
            return directoryHepler.GetFiles();
        }
    }
}
