using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet
{
    class TypeConversion
    {
        static void Main()
        {
            // simpleConversion();
            //  boxing_unboxing();
            //TypeConversion tc = null;
            //tc = new TypeConversion();
            //bool res = tc.ternaryfunction();
            //Console.WriteLine(tc.ternaryfunction());
            NullableEg.nullexample();
            Console.Read();
        }
             
       bool ternaryfunction()
        {
            int num = 10;  //assigning
            bool b;
            /* if (num == 10) //checking for a specific value
             {
                 b = true;
             }
             else
                 b = false;
             //using ternary function

             */
            b = num == 10 ? true : false;
            return b;
        }
        static void boxing_unboxing()
        {
            int x = 10;  //Value type
            object obj;  // reference type
            obj = x;   //value type to reference type - boxing
            Console.WriteLine($"Value of x {x} ");
            Console.WriteLine($" Value of obj {obj}");
            string s = "AAA";  //reference type
            obj = s; //same type
            Console.WriteLine(obj);
            float salary;  // value type
            Console.WriteLine("Please enter your salary");
           // salary = float.Parse(Console.ReadLine());  // string to float conversion - unboxing
            salary = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine(salary);

        }
        static void simpleConversion()
        {
            int i = 100;
            Console.WriteLine("The value of int :" + i);
            float f = i;  //implicit conversion
            Console.WriteLine("The value of float :" + f);

            f = 12323456.45f;
            i = (int)f;  //explicit conversion using typecast
            Console.WriteLine("----------------");
            Console.WriteLine(i);
            i = Convert.ToInt32(f); //explicit conversion using conversion function
            Console.WriteLine(i);

            //using parse and tryparse()

            string str = "100";
            //  i = int.Parse(str);  // will convert the string into int
            //  Console.WriteLine("**********");
            Console.WriteLine(i);

            // i = int.Parse(str); // throws an exception as the string has non number values also
            // we can use tryparse() instead of parse to avoid exception
            int result = 0;
            bool success = int.TryParse(str, out result);
            if (success)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Invalid Data, could not parse..");
        }
    }
}
