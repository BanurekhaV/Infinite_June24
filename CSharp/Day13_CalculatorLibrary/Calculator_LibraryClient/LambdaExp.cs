using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_LibraryClient
{
    class LambdaExp
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
            {
                36,71,12,15,29,18,27,17,9,34
            };
            //loop to display the list collection
            foreach(var item in numbers)
            {
                Console.WriteLine(item*item);
            }

            //using lambda calculate square of each number in the list
            var squares = numbers.Select(n => n * n);

            Console.WriteLine("---lambda Squares------");

            foreach(var v in squares)
            {
                Console.WriteLine(v);
            }

            //using lambda find all the numbers in the list which are divisible by 3
            List<int> divby3 = numbers.FindAll(x => (x % 3) == 0);

            Console.WriteLine("Numbers divisible by 3........");
            foreach(int x in divby3)
            {
                Console.WriteLine(x);
            }

            Console.Read();
        }
    }
}
