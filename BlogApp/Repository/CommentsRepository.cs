﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BlogApp.Repository
{
    public class CommentsRepository
    {
        public static ICollection<string> Comments = new Collection<string>(); 
    }
}