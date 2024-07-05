using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public sealed class SingletonEg
    {
        //private field to increment the counter every time an object is created
        private static int counter = 0;

        //instance object to store the singleton instance

        private static SingletonEg stobj = null;

        //public method that returns the instance of the singleton class

        public static SingletonEg GetInstance()
        {
            if(stobj == null)
            {
                stobj = new SingletonEg();
                Console.WriteLine("SingleTon Objects hash code :" + " "+ stobj.GetHashCode());
            }
            return stobj;
        }

        //private constructor so that no instance is possible outside the class
        private SingletonEg()
        {
            counter++;
            Console.WriteLine("Counter value : "+ " "+ counter.ToString());
        }

        //normal instance methods
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
