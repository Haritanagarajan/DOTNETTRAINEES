using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task7
{
    internal class RegexExp
    {
       

    }

    internal class MainRegex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mobileno" + "\n");
            var mobileno = new List<string>()
            {
            "321-0987-987",
            "6234567800",
            "72345678978",
            "1234567890",
            "1234567888"
            };
            mobileno.ForEach(x => { Console.WriteLine(Regex.IsMatch(x, @"^[1-8]{10}$") + " " + x); }) ;

            Console.WriteLine( "\n");

            Console.WriteLine("Telephoneno" + "\n");
            var telephoneno = new List<string>()
            {
            "32-0987-987",
            "32-0987-987",
            "321-0987-98",
            "3210-0987-987",
            "321-0987-987"
            };
            telephoneno.ForEach(x => { Console.WriteLine(Regex.IsMatch(x, @"^[0-9]{3}-[0-9]{4}-[0-9]{3}$") + " " + x); });

            Console.WriteLine("\n");

            Console.WriteLine("Password" + "\n");

            var Password = new List<string>
            {
                "haritanH@123",
                "ranitanR@123",
                "yamini@123",
                "sharon123",
            };

            Password.ForEach(x => Console.WriteLine(Regex.IsMatch(x, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$") + " " + x)) ;
           
            Console.ReadLine();


        }
    }
}
