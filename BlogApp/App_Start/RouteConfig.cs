﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlogApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Post", "post-{title}", new { Controller = "Home", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{title}",
                defaults: new { controller = "Home", action = "Index", title = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Post",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Title", id = "SomeTitle" }
            );
        }
    }
}