using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class RecentPostItemModel
    {
        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}