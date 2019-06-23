using System;
using System.Collections.Generic;
using PredicateDelegate.Entities;
using System.Linq;
namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv Lg 4K", 1550.00));
            list.Add(new Product("PocoPhone F1", 1800.00));
            list.Add(new Product("Xbox One X", 2200.00));
            list.Add(new Product("PS4", 2000.00));

            #region PredicateDelegate
            list.RemoveAll(ProductTest);//Remover prod com preço > que 1900.00
            //list.RemoveAll(p => p.Price >= 1900.00); Exemplo com lambida

            Console.WriteLine("Predicate Delegate:");

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            #endregion

            #region ActionDelegate
            list.ForEach(UpdateProduct);// Exibir o produtos com 10% de acréscimo.

            Console.WriteLine("Action Delegate:");

            foreach (Product p1 in list)
            {
                Console.WriteLine(p1);
            }

            Console.WriteLine();

            /*
                Outras forma de chamar a função UpdateProduct
                
                Action<Product> act = UpdateProduct;
                list.ForEach(act);

                Action(Product> act = p => {p.Price =+ p.Price * 0.1};

                list.ForEach(p => {p.Price =+ p.Price * 0.1});
            */
            #endregion

            #region Exemplo de FuncDelegate

            //Func<Product, string> func = p => p.Name.ToUpper();

            //Func<Product, string> func = NameUpper; Outra forma de chamar o Func
            //List<string> list2 = list.Select(func).ToList();

            List<string> list2 = list.Select(NameUpper).ToList();//Selecionar os elementos da lista e exibir em ToUpper
            //List<string> list2 = list.Select(p => p.Name.ToUpper()).ToList(); Lambda InLine

            Console.WriteLine("Func Delegate:");

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            #endregion

            Console.ReadLine();


        }

        #region Funções Delegate
        //Função para retornar o PredicateDelegate
        public static bool ProductTest(Product p)
        {
            return p.Price >= 1900.00;
        }

        //Função para retornar o ActionDelegate
        static void UpdateProduct(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        //Função para retornar o SelectDelegate
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        #endregion
    }
}
