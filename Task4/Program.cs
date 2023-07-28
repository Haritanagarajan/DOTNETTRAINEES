using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal partial class partialmethods
    {
        public partialmethods()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "number");
            hashtable.Add("Biscuit", "goodday");
            hashtable.Add("chocolate", "silk");
            hashtable.Add(108, "Ambulance");
            Console.WriteLine("Hashtable example 1 using DictionaryEntry :" + "\n");
            foreach (DictionaryEntry a in hashtable)
            {
                Console.WriteLine("{0} and {1} ", a.Key, a.Value);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Hashtable example 2 using initialisation values  :" + "\n");


            Hashtable hash2 = new Hashtable()
            {
                {"rain","coat" },
                {"good","mrng" },
                {"bad" ,"night"},
                {"double value" , 12.00}

            };

            foreach(DictionaryEntry b in hash2)
            {
                Console.WriteLine("{0} and {1} ", b.Value, b.Key);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Hashtable example 3 using ContainsKey and ContainsValue  returns true/false:" + "\n");

            Console.WriteLine("hashtable1 value for [1] is:" + hashtable.ContainsKey(108));

            Console.WriteLine("hashtable1 value for [1] is:" + hashtable.ContainsValue("goodday"));

            Console.WriteLine("Hashtable example 4 using direct index:" + "\n");

            Console.WriteLine("hashtable1 value for [1] is:" + hashtable[1]);

            Console.WriteLine("hashtable1 value for [1] is:" + hashtable["chocolate"]);




        }
        internal class Partialmain
        {
            static void Main(string[] args)
            {
                partialmethods method = new partialmethods();
                Console.ReadLine();
             }
        }
    }
}
