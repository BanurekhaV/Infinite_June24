using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day12_Dotnet
{
    class MultiThread
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started....");

            //let us create new threads

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            };

            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();

        }
        static void Method1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1 on Thread {0} ran {1} no of times : " ,Thread.CurrentThread.Name, i);
            }

        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : no of times : " + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing some other Large Task....");
                    Thread.Sleep(10000);
                    Console.WriteLine("Completed large task..");
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
