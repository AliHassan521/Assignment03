using System;
using Enums;
using Models;
using Factories;

namespace ECommerceOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Product Creation Test ===");

            Console.WriteLine("Select a product category:");
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Clothing");
            Console.WriteLine("3. Books");
            Console.WriteLine("4. Home & Garden");

            Console.Write("Enter option: ");
            int option = int.Parse(Console.ReadLine());

            ProductCategory selectedCategory;

            switch (option)
            {
                case 1:
                    selectedCategory = ProductCategory.Electronics;
                    break;
                case 2:
                    selectedCategory = ProductCategory.Clothing;
                    break;
                case 3:
                    selectedCategory = ProductCategory.Books;
                    break;
                case 4:
                    selectedCategory = ProductCategory.HomeGarden;
                    break;
                default:
                    Console.WriteLine("Invalid option. Exiting.");
                    return;
            }

            Product newProduct = ProductFactory.CreateProduct(selectedCategory);

            if (newProduct != null)
            {
                Console.WriteLine("\nProduct created successfully:");
                Console.WriteLine(newProduct.GetProductDetails());
            }
            else
            {
                Console.WriteLine("Failed to create product.");
            }

            var logger = Singletons.Logger.GetInstance();
            logger.LogInfo("App started.");
            logger.LogWarning("Inventory is low.");
            logger.LogError("Unable to connect to server.");

            var config = Singletons.ConfigurationManager.GetInstance();
            config.SetSetting("apiKey", "123456");
            Console.WriteLine("API Key: " + config.GetSetting("apiKey"));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
