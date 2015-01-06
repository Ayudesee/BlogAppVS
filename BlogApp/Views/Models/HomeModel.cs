using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class HomeModel

    {
        public HomeModel()
        {
           // if (Modelname.Equals("Article"))
                Article = new ArticleModel();
            //else
            //    Registration = new RegistrationModel();
        }
        public RegistrationModel Registration { get; set; }
        public ArticleModel Article { get; set; }
    }
}