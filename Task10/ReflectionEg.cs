using System;
using System.Reflection;

internal  class ReflectionEg
{
    public void Method1() { }
    public int Method2(int x) { return x; }
    public void Method3() { }

    static void Main()
    {
        // a. Create variables of various value types and display their metadata
        int intValue = 42;
        double doubleValue = 3.14;
        string stringValue = "Hello, Reflection!";
        bool boolValue = true;

        //get the type
        Type intType = intValue.GetType();
        Type doubleType = doubleValue.GetType();
        Type stringType = stringValue.GetType();
        Type boolType = boolValue.GetType();

        //displaying
        Console.WriteLine("Int type: " + intType);
        Console.WriteLine("Double type: " + doubleType);
        Console.WriteLine("String type: " + stringType);
        Console.WriteLine("Boolean type: " + boolType);
        Console.WriteLine("\n");

        // b. Display all the methods in Math Class
        Type mathclass = typeof(Math);
        MethodInfo[] mathMethods = mathclass.GetMethods();

        Console.WriteLine("Methods in Math class:");
        foreach (MethodInfo method in mathMethods)
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine("\n");
        // c. Display all the methods in the current class (ReflectionExample)
        Type currentclass = typeof(ReflectionEg);
        MethodInfo[] currentMethods = currentclass.GetMethods();

        Console.WriteLine("Methods in ReflectionEg class:");
        foreach (MethodInfo method in currentMethods)
        {
            Console.WriteLine(method.Name);
        }
        Console.ReadLine();
    }
}
