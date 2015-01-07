using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class RecentPostController : Controller
    {
        public ActionResult Recent()
        {
            ICollection<RecentPostItemModel> Items = new Collection<RecentPostItemModel>();

            var connect = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString);
            connect.Open();
            var command = new SqlCommand(String.Format("select * from Post WHERE PostID > 0 ORDER by DateCreated DESC"));
            command.Connection = connect;
            var reader = command.ExecuteReader();
            int r = 0;
            while (reader.Read() && r < 3)
            {
                RecentPostItemModel PostObj = new RecentPostItemModel();
                PostObj.Text = reader["Title"].ToString();
                r++;
                Items.Add(PostObj);
            }
            var model = new RecentPostsModel(Items);
            connect.Dispose();
            command.Dispose();
            reader.Dispose();
            return View(model);
            
        }
    }
}
