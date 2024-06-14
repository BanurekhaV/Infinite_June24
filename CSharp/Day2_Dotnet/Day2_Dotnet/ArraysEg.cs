using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] data = new int[] { 76, 4, 12, 0, 3 };
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);
            Console.WriteLine("----------Before Sort--------");
           
            for(int i=0; i<data.Length;i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("------After Sort-------");
            Array.Sort(data);

            foreach (int x in data)
            {
                Console.WriteLine(x);
            }

            Array.Reverse(data);
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }

            string[] str = new string[2] { "Hello", "World" };

            foreach(var s in str)
            {
                Console.WriteLine(s);
            }
        }

        public static void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
           
            //1 st loop to iterate the rows
           // for(int i=0; i<2;i++)  we cannot hard code any part of our application, hence
           //we will make use of GetLength()
            for(int i=0; i<myarray.GetLength(0);i++)           
            {
                //2nd loop to iterate columns
                //for(int j=0; j<3; j++)
                for(int j =0; j<myarray.GetLength(1);j++)
                {
                    Console.Write(myarray[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public static void JaggedArray()
        {
            //1. declare jagged array of 2 rows
            int[][] myjagg = new int[2][];   // only no.of rows is specified, byt col in each row is left empty

            //2. let us set the size for each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //3. let us initialize the jagges array
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //another way to initialize jagged array
            int[][] jag2 =
             {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            //to display the elements of the above jagged array, we need 2 loops
            for(int i=0; i<jag2.Length; i++)
            {
                Console.WriteLine("Number of elements at Row : " + i + " are" + " " + jag2[i].Length);

                //inner loop
                for(int j=0; j<jag2[i].Length;j++)
                {
                    Console.Write(jag2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
