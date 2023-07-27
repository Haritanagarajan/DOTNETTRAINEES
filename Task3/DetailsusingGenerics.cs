using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DetailsUsingGenerics
    {
        static void Main(string[] args)
        {
            Data3Generics<int, string, double> data3Generics = new Data3Generics<int, string, double>();

            Console.WriteLine("Enter the employee id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the employee salary:");
            double salary = Convert.ToInt64(Console.ReadLine());

            data3Generics.Details(id, name, salary);

            Console.ReadLine();
        }
    }

    internal class Data3Generics<T, T1, T2>
    {
        public void Details(T id, T1 name, T2 salary)
        {
            Console.WriteLine("Trainee empid: " + id);
            Console.WriteLine("Trainee name: " + name);
            Console.WriteLine("Trainee salary: " + salary);
        }
    }
}
