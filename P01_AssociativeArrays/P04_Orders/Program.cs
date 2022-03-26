using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P04_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> product = new Dictionary<string, Dictionary<double, int>>();
            string command;
            while ((command=Console.ReadLine())!="buy")
            {
               string[] parts = command.Split(new char[] { ' ','\t' },StringSplitOptions.RemoveEmptyEntries);
               string productName = parts[0];
               double productPrice = double.Parse(parts[1]);
                int productQuantity = int.Parse(parts[2]);
                if (product.ContainsKey(productName))
                {
                    int quantity= 0;
                    foreach (var item in product[productName])
                    {
                        quantity = item.Value;
                    }
                    product[productName] = new Dictionary<double, int>();
                    int allQuantity = quantity + productQuantity;
                    product[productName].Add(productPrice, allQuantity);
                }
                else
                {
                    product.Add(productName, new Dictionary<double, int>());
                    product[productName].Add(productPrice, productQuantity);
                }

            }
            foreach (var dictionary in product)
            {
                foreach (var item in dictionary.Value)
                {
                    Console.WriteLine($"{dictionary.Key} -> {item.Key * item.Value:f2}");
                }
            }
        }
    }
}
