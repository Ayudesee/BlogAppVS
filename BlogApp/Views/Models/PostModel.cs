using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class PostModel
    {
        public PostModel(string Title, string Body, DateTime Date)
        {
            this.Title = Title;
            this.Body = Body;
            this.Date = Date;
        }

        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}