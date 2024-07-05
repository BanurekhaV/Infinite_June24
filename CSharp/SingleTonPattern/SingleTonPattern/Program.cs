using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            SingletonEg Employee = SingletonEg.GetInstance();  //first singleton class instance is created here
            Console.WriteLine("Employee's Hash Code :" + " "+ Employee.GetHashCode());
            Employee.Show("This message is from Employee");

            //let us try creating another object
            SingletonEg Manager =  SingletonEg.GetInstance();
            Console.WriteLine("Manager's Hash Code :" + " " + Manager.GetHashCode());
            Manager.Show("This message is from Manager");

            Client2.Client2Method();
            Console.Read();
        }
    }
}
