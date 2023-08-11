using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class TupleEg2
    {
        
        public void DetailsPartition((string[] Cgvak,string[] G2tech,int strength)y)
        {

            Console.WriteLine("G2tech list is:");

            for (int i = 0; i < y.strength; i++)
            {
                if (y.G2tech[i] != null)
                {
                    Console.WriteLine(y.G2tech[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Cgvak list is:");
            for (int i = 0; i < y.strength; i++)
            {
                if (y.Cgvak[i] != null)
                {
                    Console.WriteLine(y.Cgvak[i]);

                }
            }

        }
        public static void Main(string[] args)
        {

            TupleEg2 tupleEg2 = new TupleEg2();

            string[] Name;
            string[] Cgvak;
            string[] G2tech;

            Console.WriteLine("Enter the trainee strength:");
            int strength = Convert.ToInt32(Console.ReadLine());

            Name = new string[strength];
            G2tech = new string[strength];
            Cgvak = new string[strength];

            for (int i = 0; i < strength; i++)
            {
                Console.WriteLine("Enter student name");
                Name[i] = Console.ReadLine();

                Console.WriteLine("Enter your Company as Cgvak or G2tech:");
                string companybase = Console.ReadLine();

                if (companybase == "Cgvak")
                {
                    Cgvak[i] = Name[i];
                }
                else if (companybase == "G2tech")
                {
                    G2tech[i] = Name[i];
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter 'Cg' or 'G2'.");
                    i--;
                }
            }
            Console.WriteLine("\n");

            tupleEg2.DetailsPartition((Cgvak, G2tech,strength));

            Console.ReadLine();
        }
    }

}


