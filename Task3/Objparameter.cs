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
        
        public Objparameter() { 
            id = 0;
            name = "Harita";
            city = "Coimbatore";
            designation = ".Net Full Stack";
        }


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
            objparameter.trainees(objparameter);
            Console.ReadLine();

        }
    }
}
