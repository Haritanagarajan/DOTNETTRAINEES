using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Objparameter
    {

        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string designation { get; set; }
       

        public void trainees(Objparameter val) {
            val.id = id;
            val.name = name; 
            val.city = city;
            val.designation = designation;
            Console.WriteLine(id + " " + name + " " + city + " " + designation );
        }

        static void Main(string[] args)
        {
            Objparameter objparameter = new Objparameter();

            Console.WriteLine("Enter the no of employees");
            int no =Convert.ToInt16(Console.ReadLine());

            for(int i =0; i < no; i++)
            {
                Console.WriteLine("enter emp id:");
                objparameter.id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter emp name:");
                objparameter.name=Console.ReadLine();
                Console.WriteLine("enter emp city:");
                objparameter.city=Console.ReadLine();
                Console.WriteLine("enter emp designation:");
                objparameter.designation=Console.ReadLine();
                objparameter.trainees(objparameter);
            }

           

            Console.ReadLine();



        }
    }
}
