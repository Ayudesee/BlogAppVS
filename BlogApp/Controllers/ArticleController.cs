using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Recent()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Registration()
        {
            var model = new RegistrationModel();
            return View(model);
        }

    }
}
