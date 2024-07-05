using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Client2
    {
        public static void Client2Method()
        {
            SingletonEg trainee = SingletonEg.GetInstance();
            Console.WriteLine("Client 2s Intance HashCode : "+ " " + trainee.GetHashCode());
            trainee.Show("This message is from Tainee.");
            Console.Read();
        }
    }
}
