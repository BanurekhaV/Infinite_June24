using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_DataTable
{
    class Linq_Operators
    {
        public static void Main()
        {
            //Element_At();
            // First_operators();
            //  SingleEg();
            //SortingEg();
              Sample_Thenby();
            // Sample_Groupby();
           // Simple_Seed_and_Aggregates();
            Console.Read();
        }

        static void Element_At()
        {
            string[] fruits = { "Apple", "Oranges", "Bananas", "Kiwi", "Grapes" };

            var result = fruits.ElementAt(3);
           //  result = fruits.ElementAt(5);//throws out of range exception
            result = fruits.ElementAtOrDefault(5);
            Console.WriteLine(result);
        }

        static void First_operators()
        {
            string[] colors = { "red", "blue", "green", "yellow" };
            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());
            string[] colors1 = { };
            Console.WriteLine(colors1.FirstOrDefault());
            Console.WriteLine(colors1.LastOrDefault());
        }

        static void SingleEg()
        {
            string[] names1 = { "Infinte Limited" };
            string[] names2 = { "Joe Biden", "Donald Trump", "Obama" };
            string[] empty = { };

            Console.WriteLine(names1.SingleOrDefault()); //works only if the collection has a element
           // Console.WriteLine(names2.SingleOrDefault()); //throws exception if collection has more elements
            Console.WriteLine(empty.SingleOrDefault()); //avoids exception if the collection has no elements
        }


        public static void SortingEg()
        {
            string[] name = { "Joe Biden", "Donald Trump", "Obama" };

            //sorting in ascending order
            var namesort = name.OrderBy(n => n);

            foreach(var v in namesort)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("----------descending sort------------------");
            namesort = name.OrderByDescending(n => n);

            foreach (var v in namesort)
            {
                Console.WriteLine(v);
            }
                     
        }

        //multiple sorting
        //orderby, thenby
        //orderbydescending, thenbydescending
        static void Sample_Thenby()
        {
            string[] capitals = {"Delhi","Ambal","Mumbai","abcde","Nagpur","Bangalore","Hyderabad","Chennai",
            "Ahmedabad"};

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);
            Console.WriteLine("---------Multiple regular sort----------");
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------multiple descending sort--------");

            result = capitals.OrderByDescending(c => c.Length).ThenByDescending(c => c);

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //group by

        static void Sample_Groupby()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };
                             
            var result = numbers.GroupBy(num => (num % 10 == 0));

            foreach(IGrouping<bool,int> gp in result)
            {
                if(gp.Key==true)
                {
                    Console.WriteLine("Group 1 - Divisible by 10");
                }
                else
                    Console.WriteLine("Group 2 - Not Divisible by 10");

                foreach(int n in gp)
                { 
                    Console.WriteLine(n); 
                }
            }

        }

        public static void Simple_Seed_and_Aggregates()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
           
            Console.WriteLine("Sum is :{0}", numbers.Sum());  //15
            //aggregates with seed value
            var res = numbers.Aggregate(10, (a, b) => a + b);   //25
            Console.WriteLine("Aggregates with Seed value :{0}", res);
            var result = numbers.Aggregate((a, b) => a * b);   //120
            Console.WriteLine("Aggregates 2 {0}", result);
        }
    }
}
