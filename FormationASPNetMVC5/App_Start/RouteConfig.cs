using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FormationASPNetMVC5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.IgnoreRoute("Content/{file}.json");

            routes.MapRoute(
                name: "CNF",
                url: "ChuckNorrisFacts/{language}",
                defaults: new { controller = "ChuckNorrisFacts", action = "Get", language = (string)null }
            );
        }
    }
}
