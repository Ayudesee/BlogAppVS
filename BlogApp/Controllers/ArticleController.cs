﻿using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Recent()
        {
            var model = new ArticleModel();
            return View(model);
        }

    }
}
