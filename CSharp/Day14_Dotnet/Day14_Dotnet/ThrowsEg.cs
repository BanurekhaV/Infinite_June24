using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class ThrowsEg
    {
        static void Main()
        {
            var a = Divide(10, 2);
            Console.WriteLine(a);
            Console.WriteLine(ExpressionBodiedEg.IsLeapYear());
            Console.WriteLine(ExpressionBodiedEg.IsLeapYearwithExp());
            Console.WriteLine(ExpressionBodiedEg.LeapYear());
            Console.WriteLine("-------------------");
            Console.WriteLine(ExpressionBodiedEg.Square(8));
            Console.WriteLine(ExpressionBodiedEg.CalcOps(10,5));
            Console.Read();
        }

        public static double Divide(int x, int y)
        {
            //directly throw an exception
            return y != 0 ? x % y : throw new DivideByZeroException();
        }
    }

    class ExpressionBodiedEg
    {
        public static int year = 2016;

        //without expression bodied member
        public static string IsLeapYear()
        {
            return "\n Is " + year + " a Leap Year ?" + DateTime.IsLeapYear(year);
        }
        //with expression bodied member
        public static string IsLeapYearwithExp() => "\n Is " + year + " a Leap Year ?" + DateTime.IsLeapYear(year);
        //or as below
        public static string LeapYear() => $"Is {year} a Leap Year :?" + DateTime.IsLeapYear(year);

        public static int Square(int s) => s * s;
        public static int CalcOps(int a, int b) => ((a + b) + (a - b) + (a * b) + (a / b));
    }
   
    
}
