using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{

    public enum Area
    {
        circle,
        rectangle,
        square
    }

    internal class MainEnum
    {
        static void Main(string[] args)
        {
            MainEnum mainEnum = new MainEnum();
            mainEnum.calculate(Area.circle);
            mainEnum.calculate(Area.rectangle);
            mainEnum.calculate(Area.square);
            Console.ReadLine();
        }
       
        public void calculate(Area en)
        {
           

            if (en == Area.rectangle)
            {
                Console.WriteLine("Enter length:");
                int len = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter breadth:");
                int breadth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area of rectangle is : " + len * breadth);
            }
            else if (en == Area.circle)
            {
                Console.WriteLine("Enter radius:");
                int radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area of circle is : " + 3.14 * radius * radius);
            }
            else if (en == Area.square)
            {
                Console.WriteLine("Enter side:");
                int side = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area of Square is : " + side * side);
            }
        }
    

    }
}

