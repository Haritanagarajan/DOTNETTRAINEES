using System;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using System.Dynamic;
using System.Collections.Generic;

namespace Task8
{
    internal class Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

       

        static void Csv(List<Details> trainee)
        {
            string file = @"D:\Book.csv";
            string comma = ",";
            StringBuilder output = new StringBuilder();

            string[] head = new string[] { "Id", "Name", "Salary", "Bonus" };
            output.AppendLine(string.Join(comma, head));

            foreach (Details d in trainee)
            {
                d.Bonus = d.Salary * 0.1;
                string newLine = string.Join(comma, d.Id.ToString(), d.Name, d.Salary, d.Bonus.ToString());
                output.AppendLine(newLine);
            }

            try
            {
                File.WriteAllText(file, output.ToString());
                Console.WriteLine("Data written to CSV successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Content couldn't be added to the CSV file.");
            }
        }


        public static void Main(string[] args)
        {
           

            List<Details> trainee = new List<Details>()
            {
             new Details {Id = 101 , Name = "harita" ,Salary = 200000 , Bonus = 0 }
            };


            Csv(trainee);

            string csvBookContent = File.ReadAllText(@"D:\Book.csv");

            var reader = new StringReader(csvBookContent);

            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var recods = csv.GetRecords<dynamic>();

            foreach (var r in recods)
            {
                Console.WriteLine($"{r.Bonus}");
                Console.WriteLine("helo");
            }

            Console.ReadLine();
        }
    }
}
