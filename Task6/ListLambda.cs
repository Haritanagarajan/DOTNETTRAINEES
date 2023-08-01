using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{

    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }

    internal class ListLambda
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product { Id = 1,ProductName = "plumfacewash",ProductPrice = 500},
                new Product { Id = 2,ProductName = "matelipstick",ProductPrice = 300},
                new Product { Id = 3,ProductName = "scrub",ProductPrice = 1500},
                new Product { Id = 4,ProductName = "Doveshampoo",ProductPrice = 200},
                new Product { Id = 5,ProductName = "Sunscream",ProductPrice = 800}
            };

            Console.WriteLine("Retrives the ProductDetails" + "\n");
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductPrice);
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%");
            }
            Console.WriteLine("\n");


            Console.WriteLine("Retrives the ProductDetails in Descending order" + "\n");

            var orderbyresult = from d in list
                                orderby d.Id descending, d.ProductName descending, d.ProductPrice descending
                                select new { d.Id, d.ProductName, d.ProductPrice };

            foreach (var item in orderbyresult)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.ProductName}, Price: {item.ProductPrice}");
            }
            Console.WriteLine("\n");



            Console.WriteLine("Retrives only first character form ProductName" + "\n");
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductName[0]);
            }

            Console.ReadLine();
        }
    }
}
