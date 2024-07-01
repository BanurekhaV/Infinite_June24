using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day12_Dotnet
{
    class ThreadPoolEg
    {
        static void Main()
        {
            //no pool
            //for(int i=0; i<10; i++)
            //{
            //    Thread thread = new Thread(DoSomething) { Name = "Thread " + i };
            //    thread.Start();
            //}

            //with thread pool
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(DoSomething));
            }
            Console.Read();
        }

        public static void DoSomething(Object o)
        {
            Thread thread = Thread.CurrentThread;
            string msg = $"Backgound : {thread.IsBackground}," +
                $"Thread pool : {thread.IsThreadPoolThread}," +
                $" Thread ID : {thread.ManagedThreadId}";
            Console.WriteLine(msg);
        }
    }
}

