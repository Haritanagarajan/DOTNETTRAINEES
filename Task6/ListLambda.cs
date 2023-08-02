using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    //product class
    internal class Product
    {
        //props for products
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }

    //main class
    internal class ListLambda
    {
        static void Main(string[] args)
        {
            //creating list reference generic
            List<Product> list = new List<Product>()
            {
                //initializing the values for product props
                new Product { Id = 1,ProductName = "plumfacewash",ProductPrice = 500},
                new Product { Id = 2,ProductName = "matelipstick",ProductPrice = 300},
                new Product { Id = 3,ProductName = "scrub",ProductPrice = 1500},
                new Product { Id = 4,ProductName = "Doveshampoo",ProductPrice = 200},
                new Product { Id = 5,ProductName = "Sunscream",ProductPrice = 800}
            };

            //details
            Console.WriteLine("Retrives the ProductDetails" + "\n");
            //printing
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductPrice);
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%");
            }
            Console.WriteLine("\n");

            //descending order
            Console.WriteLine("Retrives the ProductDetails in Descending order" + "\n");

            var orderbyresult = from d in list
                                orderby d.Id descending, d.ProductName descending, d.ProductPrice descending
                                select new { d.Id, d.ProductName, d.ProductPrice };
      
            //printing
            foreach (var item in orderbyresult)
            {
                Console.WriteLine($"Id: {item.Id}, ProductName: {item.ProductName}, ProductPrice: {item.ProductPrice}");
            }
            Console.WriteLine("\n");


            //first character of productname
            Console.WriteLine("Retrives only first character form ProductName" + "\n");
            //printing
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductName[0]);
            }

            Console.ReadLine();
        }
    }
}
