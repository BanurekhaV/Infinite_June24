using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day12_Dotnet
{
    class ThreadLocks
    {
        public static object tloc = new object();

        public static void LockFunction()
        {
            lock(tloc)
            {
                Console.WriteLine("CurrentThread :" + " " + Thread.CurrentThread.Name);
                for(int i=0; i<10; i++)
                {
                    Thread.Sleep(new Random().Next(5));
                    Console.WriteLine("The Value of i :{0}", i);
                }
            }
        }
    }
    class ThreadSync
    {
        static void Main()
        {
            //Thread t1 = new Thread(Function1);
            //t1.Start();

            //Thread t2 = new Thread(Function2);
            //t2.Start();

            //t1.Join();
            //t2.Join();

            Thread td1 = new Thread(new ThreadStart(ThreadLocks.LockFunction));
            td1.Name = "First Thread";
           
            Thread td2 = new Thread(new ThreadStart(ThreadLocks.LockFunction));
            td2.Name = "Second Thread";
          
            td1.Start();

            td2.Start();
            Console.Read();
        }

        public static void Function1(Object obj1)
        {
            Console.WriteLine("This is Object One.   ");
        }

        public static void Function2(Object obj2)
        {
            Console.WriteLine("This is Object Two..   ");
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Function 2 : no of times :{0}", i);
                if(i==3)
                {
                    Console.WriteLine("Starting to do a bigger task...");
                    Thread.Sleep(10000);
                    Console.WriteLine("Bigger Task Completed");
                }
            }

        }
    }
}
