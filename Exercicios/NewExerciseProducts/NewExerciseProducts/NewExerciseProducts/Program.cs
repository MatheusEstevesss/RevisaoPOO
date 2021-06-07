using NewExerciseProducts.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace NewExerciseProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported (c/u/i): ");
                char statusProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (statusProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                } 
                else if (statusProduct == 'u')
                {
                    Console.Write("Manufacture date: (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));
                } 
                else
                {
                    list.Add(new Product(name, price));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
