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
        }
        public ArticleModel Article { get; set; }
    }
}