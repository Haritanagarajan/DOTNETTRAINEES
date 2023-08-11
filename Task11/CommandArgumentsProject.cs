using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class CommandArgumentsProject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Details :)");
            string name = args[0];
            int Id = int.Parse(args[1]);
            string Designation = args[2];
            double Salary = double.Parse( args[3]);
            Console.WriteLine(name + " " + Id + " " + Designation + " " + Salary);
            Console.ReadLine();
        }
    }
}
