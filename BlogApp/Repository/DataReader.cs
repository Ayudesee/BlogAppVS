using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlogApp.Repository
{
    public class DataReader
    {
        public ArticleModel GetArticleModel(string title)
        {
            PostModel postModel = null;
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(String.Format("SELECT * FROM Post WHERE Title = '{0}'", title)))
                {
                    command.Connection = connection;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            postModel = new PostModel(
                                reader["Title"].ToString(),
                                reader["Body"].ToString(),
                                DateTime.Parse(reader["DateCreated"].ToString()));
                        }
                    }
                }
            }
            return new ArticleModel(postModel, null);
        }
    }
}