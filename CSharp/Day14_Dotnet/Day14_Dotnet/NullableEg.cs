using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class NullableEg
    {
        static void Main()
        {
            Nullable<int> i = 120;
            if(i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");

            Console.WriteLine("null condition-------");
            NullableCheck();
            Console.Read();
        }

        public static void NullableCheck()
        {
            NewEmployees newemp = new NewEmployees() { ID = 5, Name = "Tanmayee" };//null;
            
           string ename = (newemp != null) ? newemp.Name : null;
            //or we can simplify it as below
            string empname = newemp?.Name;
            Console.WriteLine(ename + " "+ empname);
        }
    }
}
