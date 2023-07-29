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
         partial void  Hash()
        {
            Hashtable hashtable = new Hashtable();

            //add
            hashtable.Add(1, "number");
            hashtable.Add("Biscuit", "goodday");
            hashtable.Add("chocolate", "silk");
            hashtable.Add(108, "Ambulance");

            //example 1 usong foreach in DictnoryEntry
            Console.WriteLine("Hashtable example 1 using DictionaryEntry :" + "\n");

            
            foreach (DictionaryEntry a in hashtable)
            {
                Console.WriteLine("{0} and {1} ", a.Key, a.Value);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Hashtable example 2 using initialisation values  :" + "\n");

            //by initializing value
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

            //contains key
            Console.WriteLine("hashtable1 value for [1] is:" + hashtable.ContainsKey(108));

            //containsvalue
            Console.WriteLine("hashtable1 value for [1] is:" + hashtable.ContainsValue("goodday"));

            Console.WriteLine("Hashtable example 4 using direct index:" + "\n");

            //using index key
            Console.WriteLine("hashtable1 value for [1] is:" + hashtable[1]);

            //using index key
            Console.WriteLine("hashtable1 value for [1] is:" + hashtable["chocolate"]);

        }
        partial void Hashset()
        {
            Console.Write("\n");

            Console.WriteLine("Example for Hashset" + "\n");

            string[] arr = new string[10];

            HashSet<string> keys = new HashSet<string>();

            //add
            keys.Add("apple");
            keys.Add("mango");
            keys.Add("orange");

            //contains
            Console.WriteLine(keys.Contains("apple"));

            //removewhere
            keys.RemoveWhere(keys.Contains);

            //clear
            keys.Clear();

            //all
            Console.WriteLine(keys.All(keys.Contains));

            foreach(var a in keys)
            {
                Console.WriteLine(a);
            }

        }

        partial void list()
        {

            Console.Write("\n");

            Console.WriteLine("Example for  LinkedList" + "\n");

            LinkedList<string> list = new LinkedList<string>();


            //addlast
            list.AddLast("a");  
            list.AddLast("b");  
            list.AddLast("c");  
            list.AddLast("d");
            list.AddLast("e");


            //addfirst
            list.AddFirst("f");
            list.AddFirst("g");
            list.AddFirst("h");

            //find
            LinkedListNode<string> found = list.Find("d");
            Console.WriteLine($"value found {found.Value}");


            //addbefore
            var n = list.AddFirst("Nagarajan");
            list.AddBefore(n, "Harita");


            //addafter
            var n1 = list.AddFirst("Ranita");
            list.AddBefore(n1, "Nagarajan");


            //contains
            Console.WriteLine($"contains a : {list.Contains("a")}");


            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            //count
            Console.WriteLine($"count is :" + list.Count);

        }

        partial void Queue()
        {

            Console.Write("\n");

            Console.WriteLine("Example for  Queue" + "\n");

            Queue<string> que = new Queue<string>();

            //add queue enqueue

            que.Enqueue("a");
            que.Enqueue("b");
            que.Enqueue("c");
            que.Enqueue("d");

            //remove queue start from first (FIFO) dequeue

            que.Dequeue();
            que.Dequeue();
            que.Dequeue();

            //add queue using enqueue
            que.Enqueue("e");
            que.Enqueue("f");

            //Peek
            Console.WriteLine("retrieves value at start : "  + que.Peek());

            //copy values to an array
            string[] arr = que.ToArray();

            foreach(var copy in arr)
            {
                Console.WriteLine($"array copy {copy} ");
            }

            // equal to itself or not
            Console.WriteLine(que.Equals(que));


            //creating shallow copy and delete the start value
            Queue<string> que2 = que;
            que2.Dequeue();
            Console.WriteLine(que);

            //count
            Console.WriteLine($"Count is: {que.Count()}");

            foreach (var a in que)
            {
                Console.WriteLine(a);
            }

        }

    }
}
