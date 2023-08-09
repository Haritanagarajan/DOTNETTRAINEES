using System;
using System.Linq;
using System.Reflection;

namespace Task10
{
    internal class CustomAttributeEg : Attribute
    {
        private string _Developername;
        private int _Developerid;

        public CustomAttributeEg(string _Developername, int _Developerid)
        {
            this._Developername = _Developername;
            this._Developerid = _Developerid;
        }

        public static void DeveloperInfo(Type ctype)
        {
            Console.WriteLine($"Information about Developers in ..., {ctype.Name}");

            //constructor
            ConstructorInfo[] constructors = ctype.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                object[] arr = constructor.GetCustomAttributes(true);
                foreach (Attribute aa in arr)
                {
                    if (aa is CustomAttributeEg customAttributeEg)
                    {
                        Console.WriteLine("Constructor: {0}, {1}, {2}", ctype.Name, customAttributeEg._Developername, customAttributeEg._Developerid);
                    }
                }
            }
            //class
            Type type = ctype;
            foreach (Object attri in type.GetCustomAttributes(true))
            {
                CustomAttributeEg customAttributeEg = (CustomAttributeEg)attri;
                if (null != customAttributeEg)
                {
                    Console.WriteLine(customAttributeEg._Developername);
                    Console.WriteLine(customAttributeEg._Developerid);
                }
            }

            //methods 
            MethodInfo[] methods = ctype.GetMethods();

            foreach (MethodInfo method in methods)
            {
                object[] arr = method.GetCustomAttributes(true);
                foreach (Attribute aa in arr)
                {
                    if (aa is CustomAttributeEg customAttributeEg)
                    {
                        Console.WriteLine("{0}-,{1},{2}", method.Name, customAttributeEg._Developername, customAttributeEg._Developerid);
                    }
                }
            }
        }
    }

    [CustomAttributeEg("Work Handled by Progect1 class: Vasanth", 191)]
    internal class Project1
    {
        int Projectid;
        string ProjectName;

        [CustomAttributeEg("Current Developer Working on Project1 constructor: Sharon", 121)]
        public Project1(int Projectid, string ProjectName)
        {
            this.Projectid = Projectid;
            this.ProjectName = ProjectName;
        }

        [CustomAttributeEg("Current Developer Working on Project1 method: Harita", 101)]
        public int Idmethod()
        {
            return Projectid;
        }

        [CustomAttributeEg("Current Developer Working on Project1 Method: Ranita", 102)]
        public string Namemethod()
        {
            return ProjectName;
        }
    }

    [CustomAttributeEg("Work Handled by Progect2 class: Saranya", 171)]
    internal class Project2
    {
        int Projectid;
        string ProjectName;

        [CustomAttributeEg("Current Developer Working on Project2 constructor: Arun", 129)]
        public Project2(int Projectid, string ProjectName)
        {
            this.Projectid = Projectid;
            this.ProjectName = ProjectName;
        }

        [CustomAttributeEg("Current Developer Working on Project2 Method: Yamini", 103)]
        public int Idmethod()
        {
            return Projectid;
        }

        [CustomAttributeEg("Current Developer Working on Project2 Method: Dharshan", 104)]
        public string Namemethod()
        {
            return ProjectName;
        }
    }

    public class CustomMainmethod
    {
        static void Main(string[] args)
        {
           

            CustomAttributeEg.DeveloperInfo(typeof(Project1));
            Console.WriteLine();
            CustomAttributeEg.DeveloperInfo(typeof(Project2));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
