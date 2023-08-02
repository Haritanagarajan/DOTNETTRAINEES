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
            Trainee t;
            t = new Trainee();
            try
            {
                Console.WriteLine("Enter the username:");
                string nameof = Console.ReadLine();
                t.Name = nameof;
                t.CSharpScore = 100;
                t.UIScore = 120;
                CheckError1(t);

            }
            catch (CharacterNameException exp1)
            {
                Console.WriteLine(exp1.Message);

            }
            try
            {

                Console.WriteLine("Enter the score:");
                int score = Convert.ToInt32(Console.ReadLine());

                t.AvgScore = score;
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
