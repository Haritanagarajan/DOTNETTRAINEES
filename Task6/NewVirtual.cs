using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    //employee class
    internal class Employee
    {
        //props like id,name,salary
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        //lambda method holds id name and sal to display
        public  string Details() => $"id is ...{Id}....name is ... {Name} .... salary is ...{Salary}";

    }

    //hr class
    internal class Hr : Employee
    {
        //props like bonus
        public double Bonus { get; set; }

        //lambda method holds bonus from hr class and salary from employee class
        public new int  Details()
        {
            if (Salary <= 10000)
            {
                Bonus = Salary * 0.1;
            }
            else
            {
                Bonus = Salary * 0.2;
            }

            Console.WriteLine($"In Hr class ... Bonus is ...{Bonus} .....Salary is {Salary}");

            return 0;
        }


    }

    //Mainprogram
    internal class NewVirtual
    {
        static void Main(string[] args)
        {
            //initializing props for hr class

            Console.WriteLine("Enter the Salary");
            double sal = Convert.ToInt64(Console.ReadLine());
            
            var detailsof = new Hr()
            {
        
                //for child class
                Salary = sal,
                Id = 1,
                Name = "SHERIN"
            };


            //invoking base class 
            Console.WriteLine(detailsof.Details());

          
            //creating instance for base class
            Employee emp=detailsof;
            
            //displays props in base class
            Console.WriteLine($"Employee class details ..{emp.Details()}");

            Console.ReadLine();
        }
    }
}
