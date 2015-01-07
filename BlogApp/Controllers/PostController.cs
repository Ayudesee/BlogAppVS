//using BlogApp.Views.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace BlogApp.Controllers
//{
//    public class PostController : Controller
//    {
//        private HomeModel model = new HomeModel();

//        public ActionResult Index()
//        {
//            return View();
//        }
//        public ActionResult update(int? id, string Title, string Body, DateTime Date)
//        {
//            PostModel post = GetPost(id);
//        }
       
//        private Post GetPost(int? id)
//        {
//            return id.HasValue ? model.Article.Where(x => x.PostID == id).First() : new Post() { PostID = -1 };
//        }
//    }
//}
