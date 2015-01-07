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
        [HttpGet]
        public ActionResult Index(string title)
        {
            if(title == null)
            {
                title = "This is my FIRST TITLE FROM DATABASE";
            }
            var readers = new DataReader();
            return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        public ActionResult Index(AddCommentModel model)//Отличается
        //public ActionResult Index(ArticleModel model)
        {
            var title = "This is my FIRST TITLE FROM DATABASE";
            var readers = new DataReader();

            if (!string.IsNullOrWhiteSpace(model.Comment))
            {
                
                readers.AddComment(title, model.Comment);

                return View(readers.GetArticleModel(title));
            }
            return View(readers.GetArticleModel(title));
        }
        

        public ActionResult AddComment(AddCommentModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
