using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    //abstract class
    internal abstract class Abstractioneg
    {

        //abstract variables
        public abstract double income { get; set; }

        //abstract method
        public abstract void Calculateincome();


    }

    //child class 1
    internal class Child1 : Abstractioneg
    {
        private double _income;
        public override double income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }

        }
        //overrided method to calculate tax
        public override void Calculateincome()
        {
            double tax = 1;    
                tax += .05 * income;
            Console.WriteLine("child1 class tax is :" + tax);
        }
    }

    //child class 2
    internal class Child2 : Abstractioneg
    {
        private double _income;

        public override double income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }

        }
        //overrided method to calculate tax
        public override void Calculateincome()
        {
            double tax = 1;

           
                tax += .08 * income;
         
            Console.WriteLine("child2 class tax is :" + tax);
        }
    }

    //child class 3
    internal class Child3 : Abstractioneg
    {
        private double _income;

        public override double income
        {
            get
            {
                return _income;
            }
            set
            {
                _income = value;
            }

        }
        //overrided method to calculate tax
        public override void Calculateincome()
        {
            double tax = 1;

                tax += .085 * income;
    
            Console.WriteLine("child3 class tax is :" + tax);
        }
    }

    //main method
    internal class MainAbstraction
    {
        static void Main(string[] args)
        {
            Abstractioneg abstractioneg;

            Console.WriteLine("Enter your name :");
            string Name1 = Console.ReadLine();

            Console.WriteLine("Enter your income :");
            double income1 = Convert.ToInt64(Console.ReadLine());


            if (income1 > 100000)
            {
                abstractioneg = new Child1();
                abstractioneg.income = income1;
                abstractioneg.Calculateincome();

            }
            else if (income1 > 10000)
            {
                abstractioneg = new Child2();
                abstractioneg.income = income1;
                abstractioneg.Calculateincome();

            }
            else
            {
                abstractioneg = new Child3();
                abstractioneg.income = income1;
                abstractioneg.Calculateincome();

            }
            Console.ReadLine();
        }


    }
}


