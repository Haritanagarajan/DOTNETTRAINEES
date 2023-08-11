using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task112
{
    internal class HybridInheritanceProject
    {
        
        public record class Amma
        {
            public void DisplayFullName1()
            {
                Console.WriteLine($"Amma");
            }
        }

        public record class Ranita :  Amma
        {
            public void DisplayFullName2()
            {
                DisplayFullName1();
                Console.WriteLine($"Ranita");
            }
        }

        public record class Harita :Amma
        {
            public void DisplayFullName3()
            {
                DisplayFullName1();
                Console.WriteLine($"Harita");
            }
        }

        public record class Srivanth : Amma
        {
            public void DisplayFullName4()
            {
                DisplayFullName1();
                Console.WriteLine($"Srivanth");
            }
        }

        static void Main(string[] args)
        {
            Srivanth srivanth = new Srivanth();
            srivanth.DisplayFullName4();
            Ranita ranita = new Ranita();
            ranita.DisplayFullName2();
            Harita harita = new Harita();
            harita.DisplayFullName3();
            Console.ReadLine();
        }

    }
}
