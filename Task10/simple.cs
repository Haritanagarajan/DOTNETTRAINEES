using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{

    internal class CustomAttributeEgg : Attribute
    {
        private int id;
        private string name;

        public CustomAttributeEgg(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static void DisplayDetails(Type classtype)
        {
            Console.WriteLine(classtype.Name);

            //constructor
            ConstructorInfo[] constructors = classtype.GetConstructors();
            foreach(ConstructorInfo con in constructors)
            {
                object[] objects = con.GetCustomAttributes(true);
                foreach(Attribute aa in objects)
                {
                    if(aa is CustomAttributeEgg customattributegg)
                    {
                        Console.WriteLine($"{classtype.Name}, {customattributegg.id},{ customattributegg.name}");
                    }
                }
            }

            //method
            MethodInfo[] methods = classtype.GetMethods();
            foreach(MethodInfo method in methods)
            {
                object[] mm = method.GetCustomAttributes(true);
                foreach(Attribute aa in mm)
                {
                    if (aa is CustomAttributeEgg customattributegg)
                    {
                        Console.WriteLine($"{classtype.Name}, {customattributegg.id},{customattributegg.name}");
                    }
                }
            }

            //class

            Type type = classtype;

            foreach(object arr in classtype.GetCustomAttributes(true))
            {
                CustomAttributeEgg customAttributeEgg = (CustomAttributeEgg)arr;
                if( null != customAttributeEgg)
                {
                    Console.WriteLine($"{classtype.Name}, {customAttributeEgg.id},{customAttributeEgg.name}");

                }
            }

            //props

            PropertyInfo[] propertyInfo = classtype.GetProperties();

            foreach(PropertyInfo prop in propertyInfo)
            {
                object[] arr = prop.GetCustomAttributes(true);

                foreach(Attribute attribute in arr)
                {
                    if(attribute is CustomAttributeEgg customAttributeEgg)
                    {
                        Console.WriteLine($"{classtype.Name}, {customAttributeEgg.id},{customAttributeEgg.name}");

                    }
                }
            }
        }
    }
    
     [CustomAttributeEgg(104, "class")]
    internal class Reflect
    {
        [CustomAttributeEgg(183, "Props")]

        public int id { get; set; }
        [CustomAttributeEgg(105, "Props")]

        public string name { get; set; }

        [CustomAttributeEgg(103, "Constructor")]
        public Reflect(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        [CustomAttributeEgg(101, "Method")]
        public int getid()
        {
            return id;
        }
        [CustomAttributeEgg(102, "Method")]

        public string getname()
        {
            return name;
        }
    }

    internal class simple
    {
        static void Main(string[] args)
        {
            CustomAttributeEgg.DisplayDetails(typeof(Reflect));
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}


