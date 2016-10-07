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
    public class DriveController : ApiController
    {
        DriveHelper dHelper = new DriveHelper();

        // GET: api/Drive
        public IEnumerable<DriveInfo> Get()
        {
            return dHelper.GetDrives(); 
        }
    }
}
