using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task9
{

    internal class TraineeEvent : EventArgs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; } 
        public double Salary { get; set; }

    }
    internal class BonusEvent
    {
        public event EventHandler<TraineeEvent> OnCreated;

        public void CreateDetails(int id, string name , string desig ,double salary )
        {
            if (OnCreated !=  null)
            {
                OnCreated(this, new TraineeEvent {Id = id , Name = name , Designation  = desig ,Salary = salary });
            }
        }
    }

    
    internal class Id
    {
        public static void Send(object sender, TraineeEvent e)
        {
            Console.WriteLine($"Id is : {e.Id}");

        }

    }

    internal class Name
    {
        public static void Send(object sender, TraineeEvent e)
        { 
            Console.WriteLine($"Employee Name is : {e.Name}");

        }

    }

    internal class Designation
    {
        public static void Send(object sender, TraineeEvent e)
        {
            Console.WriteLine($"Employee Designation is : {e.Designation}");

        }

    }

    internal class Salary
    {
        public static void Send(object sender, TraineeEvent e)
        {
            double bonus;

            if (e.Salary > 10000)

                bonus = e.Salary * 0.05;
            else
                bonus = e.Salary * 0.07;

            Console.WriteLine($"Salary of the person is : {e.Salary}");

            Console.WriteLine($"Bonus amount of the person is : {bonus}");

        }

    }
    internal class EventsEg
    {

        static void Main(string[] args)
        {
            var se = new BonusEvent();

            se.OnCreated += Salary.Send;
            se.OnCreated += Name.Send;
            se.OnCreated += Designation.Send;
            se.OnCreated += Id.Send;



            Console.WriteLine("Enter the Trainee strength:");
            int strength = int.Parse(Console.ReadLine());

            for(int i = 0; i < strength; i++)
            {
                
                
                Console.WriteLine("Enter the Trainee Id:");
                int ii = int.Parse(Console.ReadLine());
                if (!Regex.IsMatch(ii.ToString(), @"^[0-9]{1,}$"))
                {
                    Console.WriteLine("Invalid Trainee Id format. Please enter a valid 10-digit number.");
                    break;
                }
              

                Console.WriteLine("Enter the Trainee Name:");
                string nn = Console.ReadLine();
                if(!Regex.IsMatch(nn, @"^(?=.*[a-z])(?=.*[A-Z]).{3,}$"))
                {
                    Console.WriteLine("Invalid Trainee Name format. Please enter a valid  set of characters.");
                    break;

                }

                Console.WriteLine("Enter the Trainee Designation:");
                string dd = Console.ReadLine();
                if(!Regex.IsMatch(dd, @"^(?=.*[a-z])(?=.*[A-Z]).{3,}$"))
                {
                    Console.WriteLine("Invalid Trainee Designation format. Please enter a valid  set of characters.");
                    break;

                }


                Console.WriteLine("Enter the Trainee Salary:");
                double ss = double.Parse(Console.ReadLine());
                if(!Regex.IsMatch(ss.ToString(), @"^[0-9].{2,}$"))
                {
                    Console.WriteLine("Invalid Trainee Salary format. Please enter a valid  numbers.");
                    break;

                }

                se.CreateDetails(ii, nn, dd, ss);
            }

            Console.ReadLine();

        }
    }
}
