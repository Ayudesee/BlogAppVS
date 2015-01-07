using BlogApp.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Article = new ArticleModel();
        }
        public ArticleModel Article { get; set; }

        
    }
}