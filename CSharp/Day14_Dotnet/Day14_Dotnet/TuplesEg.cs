using System;
using System.Collections.Generic;


namespace Day14_Dotnet
{
    class TuplesEg
    {
        //if we want a method to return min,max,average from a given collection
        static (int,double)GetResults(List<double>numbers)
        {
            int count = 0;
            double sum = 0;
            foreach(var v in numbers)
            {
                count++;
                sum += v;
            }
            return (count, sum);
        }

        static void Main()
        {
            List<double> numbers = new List<double> { 52, 45, 120, 56, 98, 304, 20, 69 };
            var results = GetResults(numbers);
            Console.WriteLine($"Count of Number :{ results.Item1}, Sum of Numbers : {results.Item2} ");
            Console.Read();
            Tuple
        }
    }
}
