using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOTNETTRAINEES
{
    internal class Program
    {
       //normal string 
        public void String_class()
        {
            string concept = "string concept example";
            string  task = "task 1 string concept example";

            Console.WriteLine(concept + "\n");
            Console.WriteLine(task + "\n");
        }
        public void String_builderclass()
        {
            //input data from the user
            Console.WriteLine("Enter Hello :" + "\n");
            string concept1 = Console.ReadLine();

            //stringbuilder creation
            StringBuilder stringBuilder = new StringBuilder(concept1);

            //input to append 
            Console.WriteLine("Enter the text to append " + "\n");
            string addedtext=Console.ReadLine();

            //append process
            stringBuilder.Append(addedtext);

            //input to append line
            Console.WriteLine("Enter the text to appendLine " + "\n");
            string addedtextLine = Console.ReadLine();

            //appendline process
            stringBuilder.AppendLine(addedtextLine);

            //input to insert text
            Console.WriteLine("Enter the text to insert in to .. " + "\n");
            string inserttext = Console.ReadLine();

            //insert process
            stringBuilder.Insert(10, inserttext);
            Console.WriteLine(stringBuilder.ToString() + "\n");

            //input to remove startindex
            Console.WriteLine("Enter startindex .. " + "\n");
            int removestart = Convert.ToInt32(Console.ReadLine());

            //input to remove 
            Console.WriteLine("Enter number of characters to be removed from startindex .. " + "\n");
            int removestartchar = Convert.ToInt32(Console.ReadLine());

            //remove process
            stringBuilder.Remove(removestart,removestartchar);
            Console.WriteLine(stringBuilder.ToString() + "\n");

            //input to replace
            Console.WriteLine("Enter text to replace old one .. " + "\n");
            string replaceold = Console.ReadLine();

            Console.WriteLine("Enter text to replace .. " + "\n");
            string replacenew = Console.ReadLine();

            stringBuilder.Replace(replaceold, replacenew);
            Console.WriteLine(stringBuilder.ToString() + "\n");

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.String_class();
            program.String_builderclass();
            Accessspecifiers a = new Accessspecifiers();
            Console.ReadLine();
        }
    }
}
