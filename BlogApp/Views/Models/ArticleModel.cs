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
            Likes.Add(new LikeModel());
            this.NewComment = new AddCommentModel();
        }
        public ArticleModel(PostModel postModel, ICollection<string> comments, ICollection<string> usernames)
        {
            this.Title = postModel.Title;
            this.Body = postModel.Body;
            this.Date = postModel.Date;
            this.Comments = comments;
            this.Usernames = usernames;
        }
        public ArticleModel(string Titlename)
        {

        }
        public string Title { get; set; }
        public string Body { get; set; } 
        public DateTime Date { get; set; }

        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<string> Comments { get; set; }
        public ICollection<string> Usernames { get; set; }
        public AddCommentModel NewComment { get; set; }
    }
}