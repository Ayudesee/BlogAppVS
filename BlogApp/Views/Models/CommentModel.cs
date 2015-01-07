using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class CommentModel
    {
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public UserModel User { get; set; }
    }
}