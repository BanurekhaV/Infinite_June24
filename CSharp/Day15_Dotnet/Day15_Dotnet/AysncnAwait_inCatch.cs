using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class AysncnAwait_inCatch
    {
        public static void Main()
        {
            addAsync();
        }

        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 12;
            }
            catch(Exception e)
            {
                //using await operator in a catch block
                await ExceptionOccured();
                Console.WriteLine("Informed about the exception");
                Console.Read();
            }
            finally
            {
                await ReleasingResources();
                Console.Read();
            }
        }

        async static Task ExceptionOccured()
        {
            Console.WriteLine("Array Exception had Occured..");
            Task.Delay(100).Wait();
        }
        async static Task ReleasingResources()
        {
            Console.WriteLine("All resources Released.....");
            Console.Read();
        }
    }

    //Windows task demo 
}
