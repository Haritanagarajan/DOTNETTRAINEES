using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    //class
    internal class InterestCalculate
    {
        //props for principle ,years,rateofinterest
        public double Principle { get; set; }
        public int Years { get; set; }
        public int Rateofinterest { get; set; }

        //calculate method
        public void Calculate()
        {
            double SI;
            //si formula
            SI = Principle * Years * Rateofinterest / 100;
            Console.Write($" Simple Interest is : {SI}");
        }
    }

    //main class
    internal class Lambda
    {
        static void Main(string[] args)
        {
            //getting input fom user
            Console.WriteLine("Calculate simple interest" + "\n");

            Console.WriteLine("Enter the Principal Amount:");
            double principalamnt = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the No of Years :");
            int yearsval = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest:");
            int interestval = Convert.ToInt32(Console.ReadLine());

            //initializing the props 
            var lambacalculate = new InterestCalculate()
            {
                Principle = principalamnt,
                Years = yearsval,
                Rateofinterest = interestval
            };

            //passing it to calculate
            lambacalculate.Calculate();
            Console.ReadLine();
        }
    }
}
