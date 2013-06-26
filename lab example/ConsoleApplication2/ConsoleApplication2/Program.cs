using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFrom(@"F:\ConsoleApplication2\ClassLibrary1\bin\Debug\ClassLibrary1.dll");
            List<Type> types = new List<Type>();
            Type[] T = a.GetTypes();
            foreach(Type t in T)
            {
                if (!t.IsPublic || !t.IsClass || t.IsAbstract)
                    continue;

                if (typeof(DLL.Plugin).IsAssignableFrom(t))
                    types.Add(t);
            }

            foreach (Type t in types)
            {
                DLL.Plugin p = (DLL.Plugin)Activator.CreateInstance(t);
                Console.WriteLine(p.Message());
            }
        }
    }
}
