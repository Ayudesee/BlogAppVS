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
            if(title == null)
            {
                title = "This is my FIRST TITLE FROM DATABASE";
            }
            var readers = new DataReader();
           
            return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        public ActionResult AddComment(AddCommentModel model)
        {
            var title = "This is my FIRST TITLE FROM DATABASE";
            var readers = new DataReader();

            if (Request.Cookies["NameCookie"] == null)
            {
                if (!string.IsNullOrWhiteSpace(model.Comment) && !string.IsNullOrWhiteSpace(model.Username))
                {
                    readers.AddComment(title, model.Comment, model.Username);
                    
                    var cookie = new HttpCookie("NameCookie", model.Username);
                    cookie.Expires.AddMinutes(10);
                    Response.Cookies.Add(cookie);
                }
            }
            else 
            {
                var cookie = Request.Cookies.Get("NameCookie");

                if (!string.IsNullOrWhiteSpace(model.Comment))
                {
                    readers.AddComment(title, model.Comment, cookie.Value.ToString());
                }
            }
                return View(readers.GetArticleModel(title));
        }

        //[HttpGet]
        //public ActionResult Title(string id)
        //{
        //    var reader = new DataReader();
        //    return View(reader.GetArticleModel(id));
        //}
        
        

        //public ActionResult AddComment(AddCommentModel model)
        //{
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
