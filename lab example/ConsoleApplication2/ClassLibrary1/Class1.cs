using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public interface Plugin2 : DLL.Plugin
    {
        string Message2();
    }

    public class Class1 : DLL.Plugin
    {
        public string Message()
        {
            return "Class1";
        }
    }

    public class Class2 : DLL.Plugin
    {
        public string Message()
        {
            return "Class2";
        }
    }

    abstract public class Class3 : Plugin2
    {
        abstract public string Message();

        public string Message2()
        {
            return "Class3";
        }
    }

    public class Class4
    {

    }
}
