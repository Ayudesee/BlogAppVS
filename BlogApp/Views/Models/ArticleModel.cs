using BlogApp.Repository;
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
            Title = "About Me";
            Body = "<p>Шараев Владислав. Учусь в БГУИР по специальности \"инженер-системотехник\"</p>";
            Date = DateTime.Now;
            Likes = new Collection<LikeModel>();
            //Comments = new Collection<CommentItemModel>();
            Likes.Add(new LikeModel());
            //Comments.Add(new CommentItemModel());
        }
        public string Title { get; set; }
        public string Body { get; set; } 
        public DateTime Date { get; set; }

        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<string> Comments
        {
            get
            {
                return CommentsRepository.Comments; 
            }
        }
        //public ICollection<CommentItemModel> Comments { get; set; }
    }
}