using System;
using System.Text.RegularExpressions;

namespace Task7
{
    internal class CharacterNameException : Exception
    {
        public CharacterNameException(string message) : base("Should Not Contain Digits!") { }
    }

    internal class AverageScoreException : Exception
    {
        public AverageScoreException(string message) : base("Should be above 70") { }
    }

    internal class Trainee
    {
        public string Name { get; set; }
        public double CSharpScore { get; set; }
        public double UIScore { get; set; }
        public int AvgScore { get; set; }
    }

    internal class MainCustomException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username:");
            string nameof = Console.ReadLine();
            Console.WriteLine("Enter Csharpscore:");
            double Csharpscore = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter UIScore:");
            double UIScore = Convert.ToInt64(Console.ReadLine());
            double Avgscor = Csharpscore + UIScore / 2;
            Trainee t;
            t = new Trainee();
            try
            {
               
                t.Name = nameof;
                t.CSharpScore = Csharpscore;
                t.UIScore = UIScore;
                CheckError1(t);

            }
            catch (CharacterNameException exp1)
            {
                Console.WriteLine(exp1.Message);

            }
            try
            {

                t.AvgScore = (int)Avgscor;
                CheckError2(t);

            }
            catch (AverageScoreException exp2)
            {
                Console.WriteLine(exp2.Message);

            }
            Console.ReadLine();
        }

        public static void CheckError1(Trainee tr)
        {
            Regex regex1 = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[_])(?=.*[^\d]).{4,}$");

            if (!regex1.IsMatch(tr.Name))
            {
                throw new CharacterNameException(tr.Name);
            }
        }
        public static void CheckError2(Trainee trr)
        {
            if (trr.AvgScore <= 70)
            {
                throw new AverageScoreException(Convert.ToString(trr.AvgScore));
            }
        }
    }
}
