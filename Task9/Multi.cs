using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Task9
{
    internal class Multi
    {

        public void T1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("THIS IS THREAD 1");
           
        }
        public void T2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THIS IS THREAD 2");
         
        }
        public void T3() 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("THIS IS THREAD 3");
           
        }
        static void Main(string[] args)
        {
            Multi m = new Multi();

            Thread t1 = new Thread(m.T1);
            t1.Start();

            Thread t2 = new Thread(m.T2);
            t2.Start();

            Thread t3 = new Thread(m.T3);
            t3.Start();

            Console.ReadLine();

        }
    }
}
