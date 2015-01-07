using BlogApp.Views.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Collection<string> comments = null;
            Collection<string> usernames = null;
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Post WHERE Title = @title"))
                {
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("title", title));
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

                using(var command = new SqlCommand("SELECT Comment.* FROM Comment INNER JOIN Post ON Comment.PostID = Post.PostID WHERE Post.Title = @title"))
                {
                    command.Connection = connection;

                    command.Parameters.Add(new SqlParameter("title", title));
                    comments = new Collection<string>();
                    usernames = new Collection<string>();
                    using(var dataReader = command.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            comments.Add(dataReader["Body"].ToString());
                            usernames.Add(dataReader["Username"].ToString());
                        }
                    }
                }
            }
            return new ArticleModel(postModel, comments, usernames);
        }

        public void AddComment(string title, string comment, string Username)
        {
            using(var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                using( var sqlCommand = new SqlCommand(@"INSERT INTO Comment
                    SELECT PostID, @comment, @Username AS MyPost
                    FROM Post
                    WHERE Title = @title"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("comment", comment));
                    sqlCommand.Parameters.Add(new SqlParameter("Username", Username));
                    sqlCommand.Parameters.Add(new SqlParameter("title", title));
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}