using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Article = new ArticleModel();
            RecentPosts = new RecentPostsModel();
            RecentComments = new RecentCommentsModel();
        }
        public ArticleModel Article { get; set; }
        public RecentPostsModel RecentPosts { get; set; }
        public RecentCommentsModel RecentComments { get; set; }
    }
}