using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Data.DTO;
using Logic;

namespace Data.MySql
{
    public class PostContext : IPost
    {
        private readonly string _connectionString = ConnectionString.connectionStringMySql;

        private MySqlCommand cmd;

        public bool DeletePost(Post deletePost)
        {
            throw new NotImplementedException();
        }

        public bool SavePost(Post newPost)
        {
            throw new NotImplementedException();
        }

        List<Post> IPost.GetAllPost()
        {
            List<Post> posts = new List<Post>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (cmd = new MySqlCommand("GetAllPosts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                           
                            int productid = reader.GetInt32(5);
                            string coffeetype = reader.GetString(6);
                            string discription = reader.GetString(7);
                            Product product = new Product(productid, coffeetype, discription);

                            int userid = reader.GetInt32(8);
                            string name = reader.GetString(12);
                            string surname = reader.GetString(13);
                            string username = reader.GetString(9);
                            //string password = reader.GetString(10);
                            User user = new User(userid, name, surname, username, null);

                            int postid = reader.GetInt32(0);
                            Post post = new Post(postid, product, user);

                            posts.Add(post);

                        }
                    }

                    return posts;
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e);
                throw;
            }
        }


            //public bool DeletePost(Post deletePost)
            //{
            //    try
            //    {
            //        using (MySqlConnection connection = new MySqlConnection(_connectionString))
            //        {
            //            using (cmd = new MySqlCommand("DeletePost", connection)
            //            {
            //                CommandType = CommandType.StoredProcedure
            //            })
            //                cmd.Parameters.AddWithValue("@id", deletePost.Id);
            //            connection.Open();
            //            cmd.ExecuteNonQuery();
            //            return true;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        throw;
            //    }
            //}

            public List<PostDTO> GetAllPost()
        {
            
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

        }



        //public bool SavePost(Post newPost)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        //        {
        //            using (cmd = new MySqlCommand("AddPost", connection)
        //            {
        //                CommandType = CommandType.StoredProcedure
        //            })
        //                //cmd.Parameters.AddWithValue("@product_id", post.Product.Id);
        //                //cmd.Parameters.AddWithValue("@user_id", post.User.Id);
        //                //cmd.Parameters.AddWithValue("@opinion", post.comment);
        //                //cmd.Parameters.AddWithValue("@score", post.rating);
        //                connection.Open();
        //            cmd.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}
    }
}
