using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Product
    {
        public int Id { get; }
        public string CoffeeType { get; }
        public string Description { get; }

        public Product(int id, string coffeeType, string description)
        {
            Id = id;
            CoffeeType = coffeeType;
            Description = description;
        }
    }
}
