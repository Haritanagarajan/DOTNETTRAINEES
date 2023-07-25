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
            string task = "task 1 string concept example";

            Console.WriteLine(concept + "\n");
            Console.WriteLine(task + "\n");
        }
        public void String_builderclass()
        {
            //input data from the user
            Console.WriteLine("Enter Hello :");
            string concept1 = Console.ReadLine();

            //stringbuilder creation
            StringBuilder stringBuilder = new StringBuilder(concept1);

            Console.WriteLine("\n");

            //input to append 
            Console.WriteLine("Enter the text to append :");
            string addedtext = Console.ReadLine();

            //append process
            stringBuilder.Append(addedtext);

            Console.WriteLine("\n");

            //input to append line
            Console.WriteLine("Enter the text to appendLine:");
            string addedtextLine = Console.ReadLine();

            Console.WriteLine("\n");

            //appendline process
            stringBuilder.AppendLine(addedtextLine);

            Console.WriteLine("\n");

            //input to insert text
            Console.WriteLine("Enter the text to insert in to .. ");
            string inserttext = Console.ReadLine();

            //insert process
            stringBuilder.Insert(10, inserttext);
            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine("\n");

            //input to remove startindex
            Console.WriteLine("Enter startindex ..to remove: ");
            int removestart = Convert.ToInt32(Console.ReadLine());

            //input to remove 
            Console.WriteLine("Enter number of characters to be removed from startindex .. ");
            int removestartchar = Convert.ToInt32(Console.ReadLine());

            //remove process
            stringBuilder.Remove(removestart, removestartchar);
            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine("\n");

            //input to replace
            Console.WriteLine("Enter text to replace old one .. ");
            string replaceold = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Enter text to replace .. :");
            string replacenew = Console.ReadLine();

            Console.WriteLine("\n");

            stringBuilder.Replace(replaceold, replacenew);
            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine("\n");

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.String_class();
            program.String_builderclass();
            Internal i = new Internal();
            Console.ReadLine();

        }
    }
}
