using System;
using System.Threading.Tasks;

namespace Task11
{
    internal class AsyncAwaitEg1
    {
      
        static async Task<int> Sum(int x, int y, int z)
        {
            await Task.Delay(2000);
            return x + y + z;
        }

        public static async Task Main(string[] args)
        {
            int resultOfSum = await Sum(1, 2, 3);
            Console.WriteLine($"Result of Sum: {resultOfSum}");
            Console.ReadLine();
        }
    }
}
