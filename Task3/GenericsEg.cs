using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class GenericsEg
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integer or string array:");

            string val = Console.ReadLine();
         

            if (val=="integer"){
                Generics<int> Eg = new Generics<int>();

                Console.WriteLine("TASK 3 GENERICS");

                int[] rsort = new int[5];

                Console.WriteLine("Enter the elements in integer type:");

                for (int i = 0; i < 5; i++)
                {
                    rsort[i] = Convert.ToInt32(Console.ReadLine());
                }

                Eg.Generic(rsort);
            }
            else
            {
                Generics<string> Eg = new Generics<string>();

                Console.WriteLine("TASK 3 GENERICS");

                string[] rsort = new string[5];

                Console.WriteLine("Enter the elements in string type:");

                for (int i = 0; i < 5; i++)
                {
                    rsort[i] = Console.ReadLine();
                }

                Eg.Generic(rsort);
            }
            Console.ReadLine();    
        }
    }
    internal class Generics<T>
    {
        public void Generic(T[] rsort)
        {

            Array.Reverse(rsort);

            foreach(var a in rsort)
            {
                Console.WriteLine(a);
            }

        }
    }
}
