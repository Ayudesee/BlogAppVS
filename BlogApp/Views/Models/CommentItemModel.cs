using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class CommentItemModel
    {
        public CommentItemModel()
        {
            Username = "Anonimous";
            Body = "SOME COMMENT";
            Date = DateTime.Now;
        }
        public CommentItemModel(string Username, string comment)
        {
            this.Username = Username;
            this.Body = comment;
        }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}