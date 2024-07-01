using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_DotNet_ClassLibrary
{
    public class MyFirstLibraryClass
    {
        public string Welcome(string username)
        {
            return "Welcome to Class Libraries : Mr/Ms : " + username;
        }

        public void Show()
        {
            Console.WriteLine("Hope you are understanding class libraries..");
        }
    }

    public class Library2
    {
        public float Lib2_Func2()
        {
            return 3.14f;
        }
    }
}
