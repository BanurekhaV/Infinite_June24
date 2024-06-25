using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{
    public class Orders<T>
    {
        //generic private field

        private T myfield;

        //generic property for the field

        public T _myField
        {
            get
            {
                return this.myfield; //or
               // return myfield;
            }
            set { this.myfield = value; }
        }

        //generic method
        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0} : {1}" , msg, val);
        }
    }
    class Generics_Eg1
    {
        static void Main()
        {
            //instance of string type
            Orders<string> ostr = new Orders<string>();
            ostr._myField = "String Instance";
            Console.WriteLine(ostr._myField);
            ostr.Display("String argument", "abc");

            //instance of double type

            Orders<double> odbl = new Orders<double>();
            odbl._myField = 356785.456;
            Console.WriteLine(odbl._myField);
            odbl.Display("Double argument", 12345.678);
            Console.Read();
        }
    }
}
