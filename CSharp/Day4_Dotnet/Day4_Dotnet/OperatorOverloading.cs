using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Distance
    {
        public int dist1;
        public int myvariable;

        //constructor
        //public Distance(int d)
        //{
        //    dist1 = d;
        //}

        //operator overload function ' + '
        public static Distance operator +(Distance dis1, Distance dis2)
        {
            Distance temp = new Distance();
            temp.dist1 = dis1.dist1 + dis2.dist1;
           // temp.myvariable = 25;
            return temp;
        }

        public static Distance operator ++(Distance d)
        {
            Distance dtemp = new Distance();
            dtemp.dist1 = d.dist1 + 1;
            return dtemp;
        }

    }
    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1.dist1 = 50;
            d2.dist1 = 80;
            Distance totaldistance = d1 + d2;  // the operator overloaded function is called

            Console.WriteLine("The overall Distance is {0} and Myvar is {1} ", totaldistance.dist1, totaldistance.myvariable);
            d1++;
            totaldistance.dist1 = d1.dist1;
            Console.WriteLine(d1.dist1 + " "+ totaldistance.dist1);
            Console.Read();

        }
    }
}
