using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class AddCommentModel
    {
        //[Required(ErrorMessage="Пожалуйста, введите ваш комментарий.")]
        //[RegularExpression(@"[a-zа-я]+")]
        public string Comment { get; set; }
        
        public UserModel User { get; set; }
    }
}