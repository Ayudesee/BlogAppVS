using BlogApp.Views.Models;
using BlogApp.Views.Models.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BlogApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();

           // WebApiConfig.Register(GlobalConfiguration.Configuration);
           // FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            ModelBinders.Binders.Add(typeof(AddCommentModel), new MyModelBinder());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           // BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}