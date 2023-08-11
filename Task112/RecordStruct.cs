using System;

namespace Task112
{
    internal record struct RecordDetails
    {
        public string[] Name { get; init; }
        public int[] Id { get; init; }
        public string[] Desig { get; init; }
        public double[] Salary { get; init; }

        public RecordDetails(string[] name, int[] id, string[] desig, double[] salary)
        {
            Name = name;
            Id = id;
            Desig = desig;
            Salary = salary;
        }

        public static RecordDetails Details1()
        {
            string[] names = new string[2];
            int[] ids = new int[2];
            string[] desigs = new string[2];
            double[] salaries = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter name:");
                names[i] = Console.ReadLine();

                Console.WriteLine("Enter Id:");
                ids[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Desig:");
                desigs[i] = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                salaries[i] = double.Parse(Console.ReadLine());
            }

            return new RecordDetails(names, ids, desigs, salaries);
        }

        public static void Details2(RecordDetails rec)
        {
            Console.WriteLine("Bonus of the Employees:");

            for (int i = 0; i < 2; i++)
            {
                double bonus = rec.Salary[i] > 100000 ? rec.Salary[i] * 0.01 : rec.Salary[i] * 0.07;
                Console.WriteLine($"Employee name is {rec.Name[i]} with Salary of {rec.Salary[i]:C} in {rec.Desig[i]} with Bonus of {bonus:C}");

                var updatedSalary = rec.Salary[i] + bonus;
                Console.WriteLine($"Updated Salary: {updatedSalary:C}\n");
            }
        }
    }

    class RecordStruct
    {
        static void Main(string[] args)
        {
            RecordDetails recordDetails = RecordDetails.Details1();
            RecordDetails.Details2(recordDetails);

            Console.ReadLine();
        }
    }
}
