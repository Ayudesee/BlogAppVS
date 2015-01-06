using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class CommentController : Controller
    {
        public ContentResult Index()
        {
            return new ContentResult()
            {
                Content = "Test Comment INDEX()"
            };
        }
        public ActionResult Recent()
        {
            var model = new RecentCommentsModel();
            return View(model);
        }

    }
}
