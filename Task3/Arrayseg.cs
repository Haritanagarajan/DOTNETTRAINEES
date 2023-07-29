using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace Task3
{
    internal class Arrayseg
    {
        int? a = 10;
        int? b = null;
        int? c = null;
       
        
        
        static void Main(string[] args)
        {
            Arrayseg example = new Arrayseg();
            ArrayList array = new ArrayList();
            array.Add(example.a);
            array.Add(example.b);
            array.Add(example.c);
         
            foreach (var b in array)
            {
                if (b == null)
                {
                    var nullcolleace = b ?? " i have null";
                    Console.WriteLine(nullcolleace);
                }
                else
                {
                    Console.WriteLine(b);

                }
            }
            Console.ReadLine();
        }
    }

}

