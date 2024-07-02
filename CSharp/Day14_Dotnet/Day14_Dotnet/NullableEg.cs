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

            Console.WriteLine("Exception Filters--------");
            try
            {
                int b = 0;
                int x = 10 / b;
                int[] a = new int[5];
                a[10] = 15;
            }catch(Exception e)when(e.GetType().ToString()=="System.IndexOutOfRangeException")
            {
                //execute some other function if needed
                SomeotherJob();
            }
            catch(Exception e)when (e.GetType().ToString() == "System.DivideByZeroException")
            {
                Console.WriteLine("Do not divide a number by 0");
            }

            Console.WriteLine("Nameof Operator .......");
            NameofExample.NameofEg();
            Console.Read();
        }
        public static void SomeotherJob()
        {
            Console.WriteLine("A new job is executed...");
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

    class NameofExample
    {
        int[] arr = new int[5];
        public static void NameofEg()
        {
            NameofExample ne = new NameofExample();
            try
            {
                ne.show(ne.arr);
            }
            catch (Exception e)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Actual Exception occured at the method : " + nameof(ne.show));
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
            } 
            
        }
        int show(int[] x)
        {
            x[5] = 12;
            return x[5];
        }
    }
}
