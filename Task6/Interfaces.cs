using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    //interface1
    interface Shape1
    {
        //props radius
        int radius { get; set; }

        //abstract method
        void Area();
    }

    //interface 2
    interface Shape2
    {
        //props length,width
        int length { get; set; }
        int width { get; set; }

        //abstract method
        void Area();
    }

    //class inherits interface
    internal class Derives : Shape1, Shape2
    {
        public int radius { get; set; }
        public int length { get; set; }
        public int width { get; set; }

        //implementation od interface 1 method
        void Shape1.Area()
        {
            Console.WriteLine($"I am Shape 1 interface with radius {radius}");
        }

        //implementation od interface 1 method
        void Shape2.Area()
        {
            Console.WriteLine($"I am Shape 2 interface with length {length} and width {width}");
        }
    }

    //main class
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            //interface 1 obj creation
            Shape1 s1;
            s1 = new Derives();
            s1.radius = 10;
            s1.Area();

            //interface 1 obj creation
            Shape2 s2;
            s2 = new Derives();
            s2.length = 50;
            s2.width = 20;
            s2.Area();

            Console.ReadLine();
        }
    }
}
