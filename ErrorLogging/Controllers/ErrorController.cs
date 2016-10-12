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
        //Need to import Microsoft.AspNet.WebApi.Cors via nuget
        //Because this api app is running on a separate port from the angular app it needs to allow XHR from the target ng app
        [EnableCors(origins: "http://localhost:4201", headers: "*", methods: "*")]
        public void Post(string type, string message, string stack, string location)
        {
            //Log this error to the database.
            //Or Log this error to loose files
            //Or create and raise a Exception after configuring the project for Elmah
        }
    }
}
