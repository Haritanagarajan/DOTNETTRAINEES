using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class TupleEg1
    {
        public void Emp(string name ,int id ,string desig , double sal)
        {
          
            var Employeedetails = ((name,id,desig,sal));
            Console.WriteLine("\n");
            Console.WriteLine($"id is :{Employeedetails.Item2}");
            Console.WriteLine($"name is :{Employeedetails.Item1}");
            Console.WriteLine($"Designation is :{Employeedetails.Item3}");
            Console.WriteLine($"Salary is :{Employeedetails.Item4}");


        }

        static void Main(string[] args)
        {
            TupleEg1 tupleEg = new TupleEg1();

            Console.WriteLine("Enter for Looping");
            int loop = int.Parse(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Enter Id:");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Desig :");
                string Desig = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                double Salary = double.Parse(Console.ReadLine());

                tupleEg.Emp(Name,Id,Desig,Salary);

            }
            Console.Read();
        }
    }
}
