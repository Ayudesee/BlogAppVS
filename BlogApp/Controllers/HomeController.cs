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

        public ActionResult Index(int id = 0)
        {
            var model = new BlogApp.Views.Models.ArticleModel();
            return View(model);
        }

    }
}
