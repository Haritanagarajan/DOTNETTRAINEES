using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    public delegate void NumberChanger(int n);

    internal class Program
    {
        //2
        //public class SwapExample
        //{
        //    public static void Main()
        //    {
        //        int a = 10, b = 5;
        //        Console.WriteLine($"Before swap a is{a} and b is {b}");

        //        a = a * b;
        //        b = a / b;
        //        a = a / b;
        //        Console.WriteLine($"After swap a is{a} and b is {b}");
        //        Console.ReadLine();
        //    }
        //}
        //2
        //1
        //    static void Main(string[] args)
        //    {
        //        //Console.WriteLine("Enter rows count");
        //        int rows = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine("Enter cols count");
        //        int cols = Convert.ToInt32(Console.ReadLine());

        //        //int[] arr1 = new int[3, 3];
        //        int[,] arr1 = new int[rows, cols];


        //        Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
        //        Console.Write("-----------------------------------------\n");

        //        /* Stored values into the array*/
        //        Console.Write("Input elements in the matrix :\n");
        //        for (int i = 0; i < rows; i++)
        //        {
        //            for (int j = 0; j < cols; j++)
        //            {
        //                //Console.Write("element - [{0}] : ", i, j);
        //                //arr1[i][j] = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("Enter the input elements");
        //                arr1[i, j] = Convert.ToInt32(Console.ReadLine());


        //            }
        //        }

        //        Console.Write("\nThe matrix is : \n");
        //        for (int i = 0; i < rows; i++)
        //        {
        //            Console.Write("\n");
        //            for (int j = 0; j < cols; j++)
        //                //Console.Write("{0}\t", arr1[i, j]);
        //                Console.WriteLine(arr1[i, j]);
        //        }
        //        Console.Write("\n\n");
        //        Console.ReadLine();
        //    }
        //}
        //1

        //3
        //    public static void Main(string[] args)
        //    {
        //        string username = "abcd";
        //        double password = 1234;
        //        int ctr = 0;
        //        Console.Write("\n\nCheck username and password :\n");
        //        //Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
        //        //Console.WriteLine($"Default username is { 0 } and Default password is { 1 } " , "abcd", 1234);

        //        Console.WriteLine($"Default username is {username} and Default password is {password}");

        //        Console.Write("---------------------------------------\n");

        //        do
        //        {
        //            Console.Write("Input a username: ");
        //            username = Console.ReadLine();

        //            Console.Write("Input a password: ");
        //            password = double.Parse(Console.ReadLine());

        //            if (username != "abcd" || password != 1234)
        //                ctr++;
        //            else
        //            ctr = 1;

        //        }
        //        while ((username != "abcd" || password != 1234) && (ctr != 3));


        //    if (ctr == 3)
        //        {
        //            Console.Write("\nLogin attemp three or more times. Try later!\n\n");
        //        }
        //        else
        //        {
        //            Console.Write("\nThe password entered successfully!\n\n");
        //        }
        //        Console.ReadLine();
        //    }

        //}
        //3

        //4
        //     int num = 1;
        //    public void AddNum(int p)
        //    {
        //        num += p;
        //        Console.WriteLine(num);
        //    }
        //    public  void MultNum(int q)
        //    {
        //        num *= q;
        //        Console.WriteLine(num);

        //    }
        //    public  int getNum()
        //    {
        //        return num;
        //    }
        //    public static void Main(string[] args)
        //    {
        //        Program test = new Program();
        //        test.getNum();
        //        NumberChanger nc1 = new NumberChanger(test.AddNum);
        //        nc1 += test.MultNum;
        //        nc1(25);
        //        Console.ReadLine();
        //    }
        //}
        //4
    }
    //5
    //class DivNumbers
    //{
    //    public int result;
    //    public void division(int num1, int num2)
    //    {
    //        try
    //        {
    //             result = num1 / num2;
    //        }
    //        catch (DivideByZeroException e)
    //        {
    //            Console.WriteLine("Exception caught: ", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Result: {0}", result);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        DivNumbers d = new DivNumbers();
    //        d.division(2, 2);
    //        Console.ReadLine();
    //    }
    //}
    //5


    internal class pp
    {
        public void dict()
        {
            Dictionary<int, string> number = new Dictionary<int, string>();
            number.Add(1, "One");
            number.Add(3, "Three");
            number.Add(2, "Two");

            foreach (KeyValuePair<int, string> kvp in number)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities = new Dictionary<int, string[]>{
			{1,new string[] {"London", "Manchester", "Birmingham" } },
			{2, new string[] {"Chicago, New York, Washington"}},
			{3, new string[] {"Mumbai, New Delhi, Pune" } }
		    };
		
            foreach (var kvp in cities) { Console.WriteLine("Key: {0}, Value: ", kvp.Value); }

        }
        public static void Main(string[] args)
        {
            pp d = new pp();
            d.dict();
            Console.ReadLine();
        }
    }
}



    





      


