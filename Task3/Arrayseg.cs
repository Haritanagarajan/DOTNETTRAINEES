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
        static void Main(string[] args)
        {
           ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(null);
            array.Add(null);
            array.Add(3);
            array.Add(null);
           
            foreach(var b in array)
            {
                if(b == null)
                {
                 Console.WriteLine("I HAVE VALUE");
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

