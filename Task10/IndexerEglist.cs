using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class IndexerEgG
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desig { get; set; }
        public string salary { get; set; }

    }


    public class Indexxxx
    {
        private List<IndexerEgG> list = new List<IndexerEgG>()
        {
         new IndexerEgG { id = 101, name = "Harita" , desig = "FullStack" , salary = "120000"},
         new IndexerEgG { id = 102, name = "Ranita", desig = "FullStackDeveloper", salary = "110000" }
        };
    

        public string this[int Id]
        {
            get { return list.FirstOrDefault(x => x.id == Id).desig; }
            set { list.FirstOrDefault(x => x.id == Id).desig = value ; }
        }    
    }
       

   internal class IndexEglist
        {
            static void Main(string[] args)
            {
             Indexxxx indexerEg = new Indexxxx();
             Console.WriteLine(indexerEg[101]);
             Console.WriteLine(indexerEg[102]);
             Console.ReadLine();
            }
        }  
        
    
}
