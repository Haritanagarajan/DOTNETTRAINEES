using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter swapping for char or int:");
            string val = Console.ReadLine();

            if (val == "char")
            {
                GenericSwap<string> genericSwap = new GenericSwap<string>();

                Console.WriteLine("Enter val1");
                string val1=Console.ReadLine();

                Console.WriteLine("Enter val1");
                string val2 = Console.ReadLine();

                Console.WriteLine($"Before Swapping val1 is :{val1} val2 is:{val2}");

                genericSwap.Swapping(val1,val2);
            }
            else
            {
                GenericSwap<int> genericSwap = new GenericSwap<int>();

                Console.WriteLine("Enter val1");
                int val1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter val1");
                int val2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Before Swapping val1 is :{val1} val2 is:{val2}");

                genericSwap.Swapping(val1,val2);
            }
            Console.ReadLine();
        }
    }

    internal class GenericSwap<T>
    {
        public void Swapping(T val1,T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;

            Console.WriteLine($"After Swapping val1 is :{val1} val2 is:{val2}");
        }
    }
}
