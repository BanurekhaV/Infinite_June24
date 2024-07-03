using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class IteratorsEg
    {
        public static IEnumerable<string> GetList()
        {
            List<string> Countries = new List<string>() { "India", "Japan", "Korea", "China", "UK", "USA" };

            foreach(var v in Countries)
            {
                yield return v;
            }
        }

        public static IEnumerable<int> RandomYearsGeneration()
        {
            int year;
            Random random = new Random();
            while(true)
            {
                year = random.Next(2000, 2024);
                if(year % 4 == 0)
                {
                    Console.WriteLine($"This is a Leap Year : {year}");
                    yield break;
                }
                yield return year;
            }
            Console.WriteLine("Done with Random Years...");
        }
        static void Main()
        {
            IEnumerable<string> countrylist = GetList();

            foreach(var item in countrylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            foreach(int y in IteratorsEg.RandomYearsGeneration())
            {
                Console.WriteLine(y);
            }
            Console.Read();
        }
    }
}
