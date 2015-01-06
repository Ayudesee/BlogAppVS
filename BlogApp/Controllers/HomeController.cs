using BlogApp.Repository;
using BlogApp.Views.Models;
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
      
        [HttpGet]
        public ActionResult Index()
        {
            string query = Request.QueryString["Foo"];
            var model = new ArticleModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(AddCommentModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.Comment))
                CommentsRepository.Comments.Add(model.Comment);
            return View(new ArticleModel());
        }
        

        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
