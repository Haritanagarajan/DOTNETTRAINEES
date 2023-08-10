using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class TupleEg2
    {
        public void CGG2((string name, string company,int id, string desig, double sal)s)
        {
            if(s.company == "Cgvak")
            {
                Console.WriteLine("CG MEMBERS");
                Console.WriteLine($"id is :{s.id}");
                Console.WriteLine($"name is :{s.name}");
                Console.WriteLine($"name is :{s.company}");
                Console.WriteLine($"Designation is :{s.desig}");
                Console.WriteLine($"Salary is :{s.sal}");

            }
            else if(s.company == "G2tech")
            {
                Console.WriteLine("G2 MEMBERS");
                Console.WriteLine($"id is :{s.id}");
                Console.WriteLine($"name is :{s.name}");
                Console.WriteLine($"name is :{s.company}");
                Console.WriteLine($"Designation is :{s.desig}");
                Console.WriteLine($"Salary is :{s.sal}");

            }
            else
            {
                Console.WriteLine("No Company Found!...:(");
            }


        }
        static void Main(string[] args)
        {
            TupleEg2 tupleEg2 = new TupleEg2();

            Console.WriteLine("Enter for Looping");
            int loop1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < loop1; i++)
            {
                Console.WriteLine("Enter Id:");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Company Cgvak/G2tech:");
                string Company = Console.ReadLine();

                Console.WriteLine("Enter Desig :");
                string Desig = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                double Salary = double.Parse(Console.ReadLine());

                tupleEg2.CGG2((Name,Company,Id,Desig,Salary));

            }
            Console.ReadLine();
        }
    }
}
