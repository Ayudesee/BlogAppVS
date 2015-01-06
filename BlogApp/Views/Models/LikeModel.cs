using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class LikeModel
    {
        public LikeModel()
        {
            social = "FB";
            likesCount = 100;
        }
        public string social { get; set;  }
        public int likesCount { get; set; }
    }
}