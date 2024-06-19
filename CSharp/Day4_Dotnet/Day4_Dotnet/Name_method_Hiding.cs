using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class A1
    {
        public int i = 0;

        
        public void Method1(string s)
        {
            Console.WriteLine("Message from A1 {0}", s);
        }
    }

    class B1 : A1
    {

      int i;  // name hiding

        public B1(int a, int b) 
        {
            base.i = a;  // initializing base class member
            i = b;  // initializing current class member
        }
        //method hiding
        public void Method1(string str)
        {
            Console.WriteLine("Message from B1" + " " + str);
        }

        public void Show()
        {
            Console.WriteLine("i in A1 class : "+ base.i);
            Console.WriteLine("i in B1 class :" + i);
        }
    }
    class Name_method_Hiding
    {
        public static void Main()
        {
            B1 b1 = new B1(25,75);
            b1.Show();
            b1.Method1("Hi");

            Console.Read();
        }
    }
}
