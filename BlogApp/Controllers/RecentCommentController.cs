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
    public class RecentCommentController : Controller
    {
        public ActionResult Recent()
        {
            Collection<RecentCommentItemModel> Items = new Collection<RecentCommentItemModel>();

            var connect = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString);
            connect.Open();
            var command = new SqlCommand(String.Format("SELECT Comment.Body, Post.PostId, Username from Comment INNER JOIN Post ON Comment.PostID = Post.PostId WHERE Post.PostId > 0 ORDER BY Comment.CommentId desc"));
            command.Connection = connect;
            var reader = command.ExecuteReader();
            int r = 0;
            while (reader.Read() && r < 3)
            {
                RecentCommentItemModel CommentObj = new RecentCommentItemModel();
                CommentObj.Text = reader["Body"].ToString();
                CommentObj.Username = reader["Username"].ToString();
                Items.Add(CommentObj);
                r++;
            }
            var model = new RecentCommentsModel(Items);
            connect.Dispose();
            command.Dispose();
            reader.Dispose();
            return View(model);
        }

    }
}
