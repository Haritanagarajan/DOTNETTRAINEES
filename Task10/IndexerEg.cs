using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class IndexerEgG<T>
    {
        public T[] Empdetails = new T[2];

        public T this[int index]
        {
            get { return Empdetails[index]; }
            set { Empdetails[index] = value; }

        }

    }
   internal class IndexEg
        {
            static void Main(string[] args)
            {
                IndexerEgG<string> indexerEg = new IndexerEgG<string>();
                indexerEg[0] = "Harita";
            indexerEg[1] = "Harita";

            Console.ReadLine();
            }
        }  
        
    
}
