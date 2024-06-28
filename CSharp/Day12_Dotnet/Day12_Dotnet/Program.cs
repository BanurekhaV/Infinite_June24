using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Day12_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread : " + t.Name);
            Console.WriteLine("Current Thread" + Thread.CurrentThread.Name);

            Method1();
            Method2();
            Method3();
            Console.Read();
        }

        static void Method1()
        {
             for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Method 1 : no of times : "+ i);
            }

        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : no of times : " + i);
                if(i==3)
                {
                    Console.WriteLine("Performing some other Large Task....");
                    Thread.Sleep(10000);
                }
            }

        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 : no of times : " + i);
            }

        }
    }
}
