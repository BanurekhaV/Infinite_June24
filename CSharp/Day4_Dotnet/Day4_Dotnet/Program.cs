using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    public class Program
    {
        static int data1;  // private static
        string str;   // private non-static
        public float fvar;  // public non-static
        public static string s; // public and static 

         static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(data1 + " " + p.str + " " + p.fvar + " " + s);
            Console.Read();
        }
    }

    class Driver
    {
        public static void accessprogram()
        {
            Program prg = new Program();
            // prg.str; we cannot access the private members of other class, no visibility
            prg.fvar = 25.55f;  // public members of one class are accessible in others using the object
            Program.s = "Hello";  // public static members of one class are accessible in other classes using the classname
        }
    }
}
