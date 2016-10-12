using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ErrorLogging
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //This can be replaced with some call to the configuration table in the database via a biz and dal.
            //Having a configuration table means we can accept CORS from multiple locations and edit them without redeploying the application
            var CrossOriginRequestLocations = new List<string> { "http://localhost:4201", "http://localhost:4202" };

            var CrossOriginsRequestLocations = new EnableCorsAttribute(string.Join(",", CrossOriginRequestLocations), "*", "POST");
            config.EnableCors(CrossOriginsRequestLocations);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
