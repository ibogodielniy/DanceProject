﻿using System.Web.Mvc;
using System.Web.Routing;

namespace DanceProject.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Profile", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}