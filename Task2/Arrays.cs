﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Arrays
    {
        public string empname;
        public int id;
        public double salary;
        public double bonus;
        public static void D2arrays()
        {
            Console.WriteLine("2d ARRAYS");

            //input for rows and cols
            Console.WriteLine("Enter needed rows & cols");
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            //dynamic value for cols and rows
            int[,] two = new int[rows, cols];

            //loop through rows and cols and get input data
            Console.WriteLine("Enter elements for rows and cols:");

            //Loop through to get values from user
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    two[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements are:");

            //loop through elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(two[i, j] + " \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("2D to 1D array");

            //to convert twodimentional to onedimentional array
            foreach (int i in two)
            {

                Console.WriteLine(i);
            }

        }

        public static void Jaggedarrays()
        {
            Console.WriteLine("Jagged Arrays");
            //creation with 3 two dimensional and 0 elements
            //2 arrays 
            int[][,] jaggedarr = new int[3][,]
             {
             new int[, ] { {1, 3}, {5, 7} },
             new int[, ] { {0, 2}, {4, 6}, {8, 10} },
             new int[, ] { {7, 8}, {3, 1}, {0, 6} },
             };

            //loop through jagged array

            for (int i = 0; i < jaggedarr.Length; i++)
            {
             for(int j= 0;j < jaggedarr[i].Length; j++)
                {
                    Console.WriteLine(jaggedarr[i]);
                }
            }

        }


        public static void Traineedetails(params object[] elements)
        {
            Console.WriteLine("Params Concept");

            //loop through the objects
            foreach (object element in elements)
            {
                Console.WriteLine(element);
            }

        }

        public void Employees()
        {

            Console.WriteLine("Enter the empname:");
            empname = Console.ReadLine();

            Console.WriteLine("Enter the empid:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the salary:");
            salary = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the bonus amnt:");
            bonus = Convert.ToInt64(Console.ReadLine());
        }

        public void calculatebonus()
        {
            double bonuscal;

            bonuscal = 0.2 * salary;

            Console.WriteLine($"Mr/Mrs {empname} bonus amount is {bonuscal}");

            Console.WriteLine(bonuscal);
        }

        public static void Main(string[] args)
        { 
            Arrays arr = new Arrays();
            //objects for traineedetails mehod
            object[] t1 = { "Harita", 21, 6382830515, "kovaipudur" };
            object[] t2 = { "sharon", 21, 9984563765, "kovaipudur" };
            object[] t3 = { "Ranita", 21, 2351897265, "kovaipudur" };
            object[] t4 = { "Harishmitha", 21, 1237895643, "kovaipudur" };
            D2arrays();
            Jaggedarrays();
            //usingparams concept
            Traineedetails(t1);
            Traineedetails(t2);
            Traineedetails(t3);
            Traineedetails(t4);
            arr.Employees();
            arr.calculatebonus();
            Console.ReadLine();

        }
    }
}
