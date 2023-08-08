using System;
using System.Collections.Generic;

namespace Task8
{
    internal class ActionDelegateEg
    {
        public void TodoList(List<string> names)
        {
            Console.WriteLine(string.Join(", ", names));
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Learning");
            names.Add("Complete the task");
            names.Add("Water the plants");
            names.Add("Exploring");

            ActionDelegateEg actionDelegateEg = new ActionDelegateEg();

            Action<List<string>> Actiondelegate = actionDelegateEg.TodoList;

            Actiondelegate(names);  

            Console.ReadLine();
        }
    }
}
