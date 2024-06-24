﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_DotNet
{
    class Program
    {        
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
            Console.WriteLine("Enter 2 numbers :");
            a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[6]);
            Console.WriteLine(c);
                Console.Read();
            }
            
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("You cannot divide a number by Zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("All exceptions are caught here..");
            }
            finally
            {
                Console.WriteLine("Reached Finally...");
                Console.Read();
            
            }
        }
    }
}
