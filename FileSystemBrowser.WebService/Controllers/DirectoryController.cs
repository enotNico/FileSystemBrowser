﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

using FileSystemBrowser.Business;

namespace FileSystemBrowser.WebService.Controllers
{
    public class DirectoryController : ApiController
    {
        DriveHelper driveHelper = new DriveHelper();
        DirectoryHelper directoryHepler = null;
        
        public IEnumerable<DirectoryInfo> Get()
        {           
            directoryHepler = new DirectoryHelper(driveHelper.GetDrives().FirstOrDefault().Name);
            return directoryHepler.GetDirectories();
        }

        //GET: api/Directory/5
        public IEnumerable<DirectoryInfo> Get([FromUri]string path)
        {
            directoryHepler = new DirectoryHelper(path);
            return directoryHepler.GetDirectories();
        }
    }
}
