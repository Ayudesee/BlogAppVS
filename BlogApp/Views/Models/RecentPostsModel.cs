﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class RecentPostsModel
    {
        public ICollection<RecentPostItemModel> Items{ get; set; }
    }
}