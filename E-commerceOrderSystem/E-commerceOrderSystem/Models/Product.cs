using System;
using Enums;

namespace Models
{
    public abstract class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public ProductCategory Category { get; set; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }

        public abstract string GetProductDetails();
    }
}

