using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class BasicIndexers<T>
    {
        private T[] Trainee = new T[50];

        public T this[int index]
        {
            get
            {
                return Trainee[index];
            }
            set { Trainee[index] = value; }
        }
    }
        internal class BasicIndexer
        {
            public static void Main(string[] args)
            {
                BasicIndexers<int> Id = new BasicIndexers<int>();
                BasicIndexers<string> Name = new BasicIndexers<string>();
                BasicIndexers<string> Desig = new BasicIndexers<string>();
                BasicIndexers<double> Salary = new BasicIndexers<double>();

                Console.WriteLine("Employee Details count");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter Id:");
                    Id[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name:");
                    Name[i] = Console.ReadLine();

                    Console.WriteLine("Enter Desig :");
                    Desig[i] = Console.ReadLine();

                    Console.WriteLine("Enter Salary:");
                    Salary[i] = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Employee {Name[i]} is of ID {Id[i]} is getting salary {Salary[i]}  and desig is {Desig[i]}");

                }
            }
        }
    }
   

