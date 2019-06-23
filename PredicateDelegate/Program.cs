using System;
using System.Collections.Generic;
using PredicateDelegate.Entities;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV LG 4K", 1550.00));
            list.Add(new Product("PocoPhone F1", 1800.00));
            list.Add(new Product("Xbox One X", 2200.00));
            list.Add(new Product("PS4", 2000.00));

            //list.RemoveAll(p => p.Price >= 1900.00);
            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);

            }

            Console.ReadLine();
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 1900.00;
        }
    }
}
