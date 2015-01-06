using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class RecentPostsModel
    {
        public RecentPostsModel()
        {
            Items = new Collection<RecentPostItemModel>();
            Items.Add(new RecentPostItemModel());
            Items.Add(new RecentPostItemModel());
            Items.Add(new RecentPostItemModel());
        }
        public ICollection<RecentPostItemModel> Items{ get; set; }
    }
}