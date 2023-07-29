using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class callbyref
    {

        public void add(ref int a)
        {
            a = a * 500;
            Console.WriteLine("value insise the method:" + a);

        }

        static void Main(string[] args)
        {

            int a = 500;

            callbyref call = new callbyref();

            Console.WriteLine("value before executing :" + a);

            call.add(ref a);

            Console.WriteLine("value before executing :" + a);

            Console.ReadLine();

        }
    }
}
