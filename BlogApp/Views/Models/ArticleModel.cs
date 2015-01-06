using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            Title = "Default TITLE";
            Body = "<p>SOME BODY TEXT</p>";
            Date = DateTime.Now;
            Likes = new Collection<LikeModel>();
            Comments = new Collection<CommentItemModel>();
        }
        public string Title { get; set; }
        public string Body { get; set; } 
        public DateTime Date { get; set; }

        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<CommentItemModel> Comments { get; set; }
    }
}