using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Search_Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            Console.WriteLine("Enter 8 product names:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Product {i + 1}: ");
                string product = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(product))
                {
                    products.Add(product);
                }
                else
                {
                    Console.WriteLine("Invalid input. Product name cannot be empty.");
                    i--; // Retry this product input
                }
            }
            Console.Write("\nEnter a keyword to search: ");
            string keyword = Console.ReadLine();

            List<string> matches = new List<string>();

            foreach (string product in products)
            {
                if (product.ToLower().Contains(keyword.ToLower()))
                {
                    matches.Add(product);
                }
            }

            if (matches.Count > 0)
            {
                Console.WriteLine("\nMatching products:");
                foreach (string match in matches)
                {
                    Console.WriteLine($"- {match}");
                }
            }
            else
            {
                Console.WriteLine("\nNo products found.");
            }
        }
    }
}
