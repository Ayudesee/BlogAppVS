using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new BlogApp.Views.Models.HomeModel();
            //model.Body = "<p>1111111111111111111<p>";
            return View(model);
        }

    }
}
