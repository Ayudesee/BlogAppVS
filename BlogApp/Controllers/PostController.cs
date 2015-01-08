using BlogApp.Repository;
using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public ActionResult Title(string id)
        {
            var reader = new DataReader();
            return View(reader.GetArticleModel(id));

            //return RedirectToAction("Index", "Home");


            //var model = new ArticleModel(TitleName);

            //var connect = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString);
            //connect.Open();
            //var command = new SqlCommand(String.Format("select * from Post WHERE Post.Body = '@TitleName'"));
            //command.Connection = connect;
            //command.Parameters.Add(new SqlParameter("TitleName", TitleName));
            


            //var reader = command.ExecuteReader();

            //return View(model);
        }

    }
}
