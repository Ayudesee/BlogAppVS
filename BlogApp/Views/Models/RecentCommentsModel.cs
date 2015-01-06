using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class RecentCommentsModel
    {
        public RecentCommentsModel()
        {
            Items = new Collection<RecentCommentItemModel>();
            Items.Add(new RecentCommentItemModel());
            Items.Add(new RecentCommentItemModel());
            Items.Add(new RecentCommentItemModel());
        }
        public ICollection<RecentCommentItemModel> Items { get; set; }
    }
}