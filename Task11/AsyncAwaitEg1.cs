using System;
using System.Threading.Tasks;

namespace Task11
{
    public class AsyncAwaitEg1
    {
       public static async Task<int> Sum()
        {
            Console.WriteLine("Enter the Number of Integers you want to perform Addition:");
            int no = int.Parse(Console.ReadLine());

            int[] intvalue = new int[no];

            for (int i = 0; i < no; i++)
            {
                Console.Write($"Enter integer:");

                intvalue[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            foreach (int i in intvalue)
            {
                sum += i;
               
            }
            await Task.Delay(5000);

            return sum;
        }

        public static async Task<int> Product()
        {
            Console.WriteLine("Enter the Number of Integers you want to perform  Multiplication:");
            int no = int.Parse(Console.ReadLine());

            int[] intvalue = new int[no];

            for (int i = 0; i < no; i++)
            {
                Console.Write($"Enter integer:");

                intvalue[i] = int.Parse(Console.ReadLine());
            }

            int product = 1;

            foreach (int i in intvalue)
            {
                product *= i;

            }
            await Task.Delay(0);

            return product;
        }

        public static async Task Main(string[] args)
        {             
                int resultOfSum = await Sum();
                int resultOfProduct = await Product();
                Console.WriteLine($"Product is :{resultOfProduct}");
                Console.WriteLine($"Sum is :{resultOfSum}");
                Console.ReadLine();
        }
    }
}
