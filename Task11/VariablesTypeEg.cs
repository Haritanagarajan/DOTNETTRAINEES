using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class VariablesTypeEg
    {
        public static int staticvar = 20; 
        public readonly int readvar = 10;
        public const double constvar = 20.0; //cannoit initialize in constructor
        public int instancevar = 30;

       public VariablesTypeEg(int i)
        {
             readvar = i;
             instancevar = i;
             staticvar = i;
             //constvar = i;

        }
        public void Show()
        {
            Console.WriteLine($"Instance Variable :{instancevar}");
            Console.WriteLine($"Static Variable :{staticvar}");
            Console.WriteLine($"ReadOnly Variable :{readvar}");
            Console.WriteLine($"Const Variable :{constvar}");
            Console.WriteLine("\n");    
        }
        public void Add()
        {
            Console.WriteLine($"STATIC:{staticvar}... INSTANCE:{instancevar}...READONLY:{readvar}");
            Console.WriteLine( staticvar + instancevar + readvar);
            Console.WriteLine("\n");

        }

       public static void Main(string[] args)
        {
            
            Console.WriteLine("\n");

            VariablesTypeEg variablesTypeEg = new VariablesTypeEg(10);
            VariablesTypeEg variablesTypeEg1 = new VariablesTypeEg(90);
            variablesTypeEg.Add();
            variablesTypeEg.Show();

            Console.WriteLine($"Instance Variable class1:{variablesTypeEg.instancevar}");
            Console.WriteLine($"Static Variable :{VariablesTypeEg.staticvar}");
            Console.WriteLine($"Instance Variable class2:{variablesTypeEg1.instancevar}");

            Console.WriteLine("\n");

            Console.Read();
        }
    }
}
