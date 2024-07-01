using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day13_DotNet_ClassLibrary;

namespace Day13_Dotnet_LibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstLibraryClass mfc = new MyFirstLibraryClass();
            Console.WriteLine(mfc.Welcome("Shreyash")); 
            mfc.Show();

            Library2 l2 = new Library2();
            Console.WriteLine(l2.Lib2_Func2());

            
            Console.Read();

        }
    }
}
