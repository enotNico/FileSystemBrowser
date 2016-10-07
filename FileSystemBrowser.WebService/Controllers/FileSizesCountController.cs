using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using FileSystemBrowser.Business;

namespace FileSystemBrowser.WebService.Controllers
{
    public class FileSizesCountController : ApiController
    {
        FileSizesHelper fszHepler = null;

        public HttpResponseMessage Get([FromUri]string path)
        {
            fszHepler = new FileSizesHelper(path);
            int[] sizes = fszHepler.GetFileSizes();

            return Request.CreateResponse(HttpStatusCode.OK, new { less10 = sizes[0], More10Less50 = sizes[1], More100 = sizes[2] });
        }
    }
}
