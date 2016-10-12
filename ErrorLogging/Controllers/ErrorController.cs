using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ErrorLogging.Controllers
{
    public class ErrorController : ApiController
    {
        public void Post(string type, string message, string stack, string location)
        {
            //Log this error to the database.
            //Or Log this error to loose files
            //Or create and raise a Exception after configuring the project for Elmah
        }
    }
}
