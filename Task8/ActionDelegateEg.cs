using System;
using System.Collections.Generic;

namespace Task8
{
    public delegate void ActionList(ref List<string> names);

    internal class ActionDelegateEg
    {
        public void TodoList(ref List<string> names)
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

            ActionList ll = actionDelegateEg.TodoList;

            ll(ref names);

            Console.ReadLine();
        }
    }
}
