using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //main partial class
    internal partial class partialmethods
    {
       partial void Hash();
        partial void Hashset();

        partial void Queue();
        partial void list();
        internal class Partialmain
        {
            static void Main(string[] args)
            {
                partialmethods method = new partialmethods();
                method.Hash();
                method.Hashset();
                method.list();
                method.Queue();
                Console.ReadLine();
            }
        }
    }
}
