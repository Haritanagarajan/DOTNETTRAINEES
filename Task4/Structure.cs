using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            structeg s = new structeg();
            s.attendance();
            Console.ReadLine();
        }
    }

    internal struct structeg
    {
        string[] present;
        string[] absent;
        string[] stuname;

        public void attendance()
        {
            Console.WriteLine("Structure Example");

            Console.WriteLine("Enter the trainee strength:");
            int strength = Convert.ToInt32(Console.ReadLine());

            stuname = new string[strength];
            present = new string[strength];
            absent = new string[strength];

            for (int i = 0; i < strength; i++)
            {
                Console.WriteLine("Enter student name");
                stuname[i] = Console.ReadLine();

                Console.WriteLine("Enter your Attendance as present or absent:");
                string attendance = Console.ReadLine();

                if (attendance == "absent")
                {
                    absent[i] = stuname[i];
                }
                else if (attendance == "present")
                {
                    present[i] = stuname[i];
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter 'present' or 'absent'.");
                    i--;
                }
            }


            Console.WriteLine("Absentees list is:");

            for (int i = 0; i < strength; i++)
            {
                if (absent[i] != null)
                {
                    Console.WriteLine(absent[i]);
                }
            }
            Console.WriteLine("students present  list is:");
            for (int i = 0; i < strength; i++)
            {
                if (present[i] != null)
                {
                    Console.WriteLine(present[i]);
                    Console.WriteLine($"Students strength is : {present[i]}");

                }
            }
        }
    }
}
