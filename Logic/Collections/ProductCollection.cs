using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class ProductCollection
    {   
        private List<Product> ProductList = new List<Product>();
        public void Add(Product product)
        {
            ProductList.Add(product);
        }

        public void Remove(Product product)
        {
            ProductList.Remove(product);
        }

        public List<Product> GetAll()
        {
            return ProductList;
        }
    }
}
