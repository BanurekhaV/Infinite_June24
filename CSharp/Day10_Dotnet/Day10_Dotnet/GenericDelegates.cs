using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    public delegate T Trans<T>(T arg);  // generic delegate
    class GenericDelegates
    {
        public static void Transform<T>(T[] val, Trans<T> t)
        {
            for(int i=0; i<val.Length;i++)
            {
                val[i] = t(val[i]);  // 4, 5,6  = 16, 25, 36
            }
        }
    }

    class TestGenericDelegate
    {
        static void Main()
        {
            int[] data = new int[] { 4, 5, 6 };

            GenericDelegates.Transform(data, Square);
            foreach(var v in data)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine("-------- Generic Delegate in action -------");
            float[] data1 = new float[] { 4.4f, 5.5f, 6.6f };

            GenericDelegates.Transform(data1, Square);
            foreach (var v in data1)
            {
                Console.Write(v + " ");
            }

            //example of anonymous type (types that are not specific)

            var myAnonymoustype = new
            {
                data1 = "CSharp",
                data2 = 125,
                data3 = true
            };

            Console.WriteLine(myAnonymoustype);
            Console.WriteLine(myAnonymoustype.GetType().ToString());
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static float Square(float x)
        {
            return x * x;
        }
    }

}
