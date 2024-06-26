using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class MulticastDelegates
    {
        public delegate void Multicastdel();
        public static void Main()
        {
            //one way of multicasting
            //Multicastdel m1, m2, m3, m4;
            //m1 = new Multicastdel(Method1);
            //m2= new Multicastdel(Method2);
            //m3= new Multicastdel(Method3);
            //m4 = m1 + m2 + m3;  // adding multiple delegate objects
            //m4();

            //m4 -= m2;   //removing m2 delegate from the multicast 
            ////or m4 = m1+m3-m2
            //m4();

            //2nd way to multicast
            Multicastdel md1 = new Multicastdel(Method1);
            md1 += Method2;
            md1 += Method3;
            md1();
            Console.WriteLine("-----------");
            md1 -= Method1;
            md1();

            Console.WriteLine("Multicast with return values .......");
            //creating the object of the class which implements functions with int return type
            MulticastDelegatesWithReturn mdr = new MulticastDelegatesWithReturn();
            NumberChanger numc = new NumberChanger(mdr.Square);
            numc += mdr.Triple;
            int result = numc(5);
            Console.WriteLine("The return value is {0}", result);
            Console.Read();
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1..");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2..");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3..");
        }
    }

    class MulticastDelegatesWithReturn
    {
        static int p;

        public int Square(int x)
        {
            p = x * x;
            Console.WriteLine(p + " is the current value of p");
            return p;
        }

        public int Triple(int q)
        {
            p = q * q * q;
            Console.WriteLine(p + " is the current value of p");
            return p;
        }
    }
}
