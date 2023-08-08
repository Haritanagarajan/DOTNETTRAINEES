using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class FuncDelegateEg
    {

        static int Funn(int num)
        {
            Console.WriteLine("Multiplication table using Func Delegate ");
 

            for(int i = 0;  i <= 10; i ++)
            {
                Console.WriteLine($"{num} * {i}  =  {num * i}" );
            }

            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the table number ");

            int num = int.Parse(Console.ReadLine());

            Func<int, int> Mul = Funn;

            int result = Mul(num);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

