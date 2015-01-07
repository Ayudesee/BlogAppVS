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
      
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    string query = Request.QueryString["Foo"];
        //    var model = new ArticleModel();
        //    return View(model);
        //}
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
        {
            var title = "This is my FIRST TITLE FROM DATABASE";


            if (!string.IsNullOrWhiteSpace(model.Comment))
            {
                var readers = new DataReader();
                readers.AddComment(title, model.Comment);
                //CommentsRepository.Comments.Add(model.Comment);
                return View(readers.GetArticleModel(title));
            }
            return View(model);
        }
        

        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
