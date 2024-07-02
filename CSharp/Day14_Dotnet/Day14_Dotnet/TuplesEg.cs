using System;
using System.Collections.Generic;


namespace Day14_Dotnet
{
    class TuplesEg
    {
        //if we want a method to return many values from a given collection
        //tuple values displayed using standard item collection viz item1, item2 ... etc
        static (int, double) GetResults(List<double> numbers)
        {
            int count = 0;
            double sum = 0;
            foreach (var v in numbers)
            {
                count++;
                sum += v;
            }
            return (count, sum);
        }

        //tuples with named return parameters

        static (int count, double sum) GetResults1(List<double> numbers)
        {
            int count = 0;
            double sum = 0;
            foreach (var v in numbers)
            {
                count++;
                sum += v;
            }
            return (count, sum);
        }
        static void Main()
        {
            
            Console.WriteLine("----Tuples befor 7.0---------");
            //tuples before C#7.0
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            Tuple<int, double> t = GetValues(values);
            Console.WriteLine($"There are {t.Item1} elements and their Sum is {t.Item2}");

            //tuples with 7.0
            List<double> numbers = new List<double> { 52, 45, 120, 56, 98, 304, 20, 69 };
            var results = GetResults(numbers);
            Console.WriteLine($"Count of Numbers :{ results.Item1}, Sum of Numbers : {results.Item2} ");

            //with named parameters
            var res = GetResults1(numbers);
            Console.WriteLine($" Count of numbers {res.count}, and the Sum of Numbers :{res.sum}");

            //explicit names to store the return values
            var (countresult, sumresult) = GetResults1(numbers);
            Console.WriteLine($" Count of numbers {countresult}, and the Sum of Numbers :{sumresult}");
            Console.Read();

        }

        static Tuple<int,double>GetValues(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0;
            foreach(var v in values)
            {
                count++;
                sum += v;
            }
            //creating a tuple instance using static create method with items
            Tuple<int, double> t1 = Tuple.Create(count, sum);
            return t1;
        }
    }
}
