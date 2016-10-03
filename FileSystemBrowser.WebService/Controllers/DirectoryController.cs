using System;
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

        // GET: api/Directory
        public IEnumerable<DirectoryInfo> Get()
        {
            directoryHepler = new DirectoryHelper(driveHelper.GetDrives().FirstOrDefault().Name);
            return directoryHepler.GetDirectories();
        }

        // GET: api/Directory/5
        //public string Get(int id)
        //{
         //   return "value";
        //}

        // POST: api/Directory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Directory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Directory/5
        public void Delete(int id)
        {
        }
    }
}
