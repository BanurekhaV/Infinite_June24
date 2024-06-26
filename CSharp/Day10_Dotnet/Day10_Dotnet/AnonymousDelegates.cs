using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class AnonymousDelegates
    {
        delegate void Print(int x);

        static void Main()
        {
            int i = 100;
            Print p = delegate (int a)   // delegate calling an anonymous method
            {
                a += i;
                Console.WriteLine("We are inside an Anonymous method..{0}", a);
            };
           
            p(10);
          

            //eg 2

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evennos = Array.FindAll(numbers, delegate (int num)
            {
                return num % 2 == 0;
            });

            Console.WriteLine("----- even Nos------");
            foreach(int x in evennos)
            {
                Console.WriteLine(x);
            }

            p(500);

            Console.WriteLine("======= Predicate  Delegate ====");
            Predicate<string> chkupper = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };

            //calling predicate delegate
            bool res = chkupper("HELLO World");
            Console.WriteLine(res);

            Console.WriteLine("========= Action Delegate ======");

            Action<int> Simpleaction = delegate (int x)
            {
                Console.WriteLine("The Value of x {0} ", x);
            };

            Simpleaction(200);

            Console.WriteLine("======== Function Delegate =======");
            Func<int> getRnumber = delegate ()
            {
                Random r = new Random();
                return r.Next(1, 100);
            };

            //the above func delegate can be used with lambda expressions
            Func<int> grn = () => new Random().Next(1, 100);

            Func<int, int, int> Sum = (x, y) => x + y;

            int result = getRnumber();
            Console.WriteLine(result);
            Console.WriteLine(grn());
            Console.WriteLine(Sum(5,10));
            Console.Read();
        }
    }
}
