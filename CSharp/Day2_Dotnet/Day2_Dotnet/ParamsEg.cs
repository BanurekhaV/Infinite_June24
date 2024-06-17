using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class ParamsEg
    {
        public static void Main()
        {
            ParamsEg paramseg = new ParamsEg();
            int result =  paramseg.AddElements();  // calling the function with 0 arguments
            Console.WriteLine("The total is :{0}", result);
            result = paramseg.AddElements(5);  //calling function with one argument
            Console.WriteLine("The total is :{0}", result);
            result = paramseg.AddElements(2, 3, 5, 8, 1, 4); // passing comma seperated values
            Console.WriteLine("The total is :{0}", result);

            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            result=paramseg.AddElements(numbers); //passing an array variable
            Console.WriteLine("The total is :{0}", result);
            Console.WriteLine("-----------------");
            //2nd example of params
            Add(5, 10.6f);
            Add(10, 125.55f,12.45,345.56,123456.678); //3 arguments for params
            Console.Read();
                        
        }

        public int AddElements(params int[]arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i; 
            }
            return sum;
        }

                             //1 and 2 compulsory arguments, 3rd is params
        public static void Add(int x, float f, params double[] d)
        {
            Console.WriteLine("{0}, {1}", x,f);
           
            Console.WriteLine("There are {0} number of elements in the Array", d.Length);
            foreach(double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }
    }
}
