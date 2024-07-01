using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Day12_Dotnet
{
    class ThreadStateEg
    {
        static void Main()
        {
            try
            {
                //unstarted state
                Thread t1 = new Thread(SomeFunction);
                Console.WriteLine($"Before Start , ISAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                //runnable
                t1.Start();
                Console.WriteLine($"Before Start , ISAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                //nor runnable
                t1.Suspend();
                
                Console.WriteLine($"Before Start , ISAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                //resume
                t1.Resume();
                Console.WriteLine($"Before Start , ISAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                //terminate
                t1.Abort();
                Console.WriteLine($"Before Start , ISAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                t1.Start();
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public static void SomeFunction()
        {
            for(int i=0; i<3;i++)
            {
                Thread.Sleep(2000);
            }
            Console.WriteLine("Some Function completed work" + " ");
        }
    }
}
