using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Data.MySql
{
    class ProductContext
    {
        private readonly string _connectionString = ConnectionString.connectionStringMySql;

        private MySqlCommand cmd;
        //public void Create(Logic.Product product)                   
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        //        {
        //            using (cmd = new MySqlCommand("AddProduct", connection)
        //            {
        //                CommandType = CommandType.StoredProcedure
        //            })
        //            cmd.Parameters.AddWithValue("@CoffeeType", product.CoffeeType);
        //            cmd.Parameters.AddWithValue("@Description", product.Description);

        //            connection.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //public void Delete(int ProductId)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        //        {
        //            using (cmd = new MySqlCommand("DeleteProduct", connection)
        //            {
        //                CommandType = CommandType.StoredProcedure
        //            })
        //            cmd.Parameters.AddWithValue("@CoffeeId", ProductId);

        //            connection.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}
    }
}
