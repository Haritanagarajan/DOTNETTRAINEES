using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETTRAINEES
{
    public class Public
    {

        public Public() {
            Console.WriteLine("Welcome to public class");

            //example for float decimal and double

            decimal decimalvalue = 0.12345678910m;
            float floatvalue = 0.1023f;
            double doublevalue = 1.23456789d;

            Console.WriteLine($"{decimalvalue} {doublevalue} {floatvalue}");////////
        }

       
    }
}
