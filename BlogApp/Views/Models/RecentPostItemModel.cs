using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class RecentPostItemModel
    {
        public RecentPostItemModel()
        {
            Text = "Some Text for Recent Posts";
            URL = "http://vk.com/";
            Date = DateTime.Now.AddDays(-1);
        }

        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}