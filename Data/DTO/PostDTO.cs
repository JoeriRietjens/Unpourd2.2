using System;
using System.Collections.Generic;
using System.Text;
using Data.MySql;

namespace Data.DTO
{
    public class PostDTO
    {
        public int ProductId { get; private set; }
        public string CoffeeType { get; private set; }  
        public string Description { get; private set; }


        public int UserId { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Username { get; private set; }


        public int PostId { get; private set; }

        public PostDTO(int productId, string coffeeType, string description, int userId, string name, string surname, string username, int postId)
        {
            ProductId = productId;
            CoffeeType = coffeeType;
            Description = description;

            UserId = userId;
            Name = name;
            Surname = surname;
            Username = username;

            PostId = postId;
        }
    }
}

