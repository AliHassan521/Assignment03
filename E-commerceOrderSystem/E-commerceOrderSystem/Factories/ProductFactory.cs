using System;
using Enums;
using Models;

namespace Factories
{
    public class ProductFactory
    {
        public static Product CreateProduct(ProductCategory category)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter stock quantity: ");
            int stock = int.Parse(Console.ReadLine());

            Product product = null;

            if (category == ProductCategory.Electronics)
            {
                Console.Write("Enter warranty in months: ");
                int warranty = int.Parse(Console.ReadLine());

                product = new Electronics
                {
                    Name = name,
                    Price = price,
                    Stock = stock,
                    Category = category,
                    Warranty = warranty
                };
            }
            else if (category == ProductCategory.Clothing)
            {
                Console.Write("Enter size (e.g., M, L, XL): ");
                string size = Console.ReadLine();

                Console.Write("Enter material: ");
                string material = Console.ReadLine();

                product = new Clothing
                {
                    Name = name,
                    Price = price,
                    Stock = stock,
                    Category = category,
                    Size = size,
                    Material = material
                };
            }
            else if (category == ProductCategory.Books)
            {
                Console.Write("Enter ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Enter author name: ");
                string author = Console.ReadLine();

                product = new Book
                {
                    Name = name,
                    Price = price,
                    Stock = stock,
                    Category = category,
                    ISBN = isbn,
                    Author = author
                };
            }
            else if (category == ProductCategory.HomeGarden)
            {
                Console.Write("Enter usage (Indoor / Outdoor): ");
                string usage = Console.ReadLine();

                product = new HomeGarden
                {
                    Name = name,
                    Price = price,
                    Stock = stock,
                    Category = category,
                    Usage = usage
                };
            }
            else
            {
                Console.WriteLine("Invalid category selected.");
            }

            return product;
        }
    }
}
