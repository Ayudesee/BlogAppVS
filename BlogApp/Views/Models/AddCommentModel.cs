using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Views.Models
{
    public class AddCommentModel
    {
        [Required(ErrorMessage="Пожалуйста, введите ваш комментарий.")]
        public string Comment { get; set; }

        public string Username { get; set; }
    }
}