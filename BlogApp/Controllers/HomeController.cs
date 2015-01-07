using BlogApp.Repository;
using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {
            //FormsAuthentication.SetAuthCookie("Alex", true);

            if(title == null)
            {
                title = "This is my FIRST TITLE FROM DATABASE";
            }
            var readers = new DataReader();
            return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        public ActionResult Index(AddCommentModel model)
        {
            var title = "This is my FIRST TITLE FROM DATABASE";
            var readers = new DataReader();

                if (!string.IsNullOrWhiteSpace(model.Comment) && !string.IsNullOrWhiteSpace(model.Username))
                {
                    readers.AddComment(title, model.Comment, model.Username);
                }
                return View(readers.GetArticleModel(title));
        }
           
        
        

        public ActionResult AddComment(AddCommentModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
