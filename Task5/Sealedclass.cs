using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    sealed internal class Sealedclass
    {
        public void add()
        {
            int a = 10;
            int b = 30;
            int c = 50;
            int sum = a + b + c;
            Console.Write(sum);
        }
    }

    //sealedclass cannot be inherited since it has keyword sealed

    //public class class2:Sealedclass
    //{
    //    Console.WriteLine("Cannot be inherited warning !");
    //}

    internal class MainSealed
    {
        static void Main(string[] args)
        {
        Sealedclass  sealedclass = new Sealedclass();
            sealedclass.add();
            Console.ReadLine();
        }
    }
}
