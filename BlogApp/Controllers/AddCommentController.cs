using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class AddCommentController : Controller
    {
        //
        // GET: /AddComment/

        public ActionResult Index()
        {
            var model = new AddCommentModel();
            return View(model);
        }

    }
}
