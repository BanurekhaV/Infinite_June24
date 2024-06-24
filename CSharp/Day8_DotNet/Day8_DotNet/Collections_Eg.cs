using System;
using System.Collections.Generic;
using System.Collections;


namespace Day8_DotNet
{
    class Collections_Eg
    {
        public static void ArrayListEg()
        {
            ArrayList arrlst1 = new ArrayList();
            arrlst1.Add(10);
            arrlst1.Add("AAA");
            arrlst1.Add(456.56f);
            arrlst1.Add(true);
            arrlst1.Add('y');
            arrlst1.Add(false);
            arrlst1.Add('b');
            arrlst1.Add(345);
            arrlst1.Add("AAA");

            Console.WriteLine(arrlst1.Count + " "+ arrlst1.Capacity);

            foreach(var item in arrlst1)
            {
                Console.WriteLine(item);
            }

            arrlst1.RemoveAt(3);
            Console.WriteLine("-------------------");
            foreach (var item in arrlst1)
            {
                Console.WriteLine(item);
            }

            ArrayList arrlst2 = new ArrayList();
            arrlst2.Add(45);
            arrlst2.Add(3);
            arrlst2.Add(123);
            arrlst2.Add(15);

            //adding a range of values into another arraylist

            arrlst1.InsertRange(1, arrlst2);
            Console.WriteLine("------After Adding another collection--------");
            foreach (var item in arrlst1)
            {
                Console.WriteLine(item);
            }

            arrlst2.Sort();
            foreach (var item in arrlst2)
            {
                Console.WriteLine(item);
            }
        }

        public static void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E004", "Santosh");
            ht.Add("E003", "Pratheeba");
            ht.Add("E006", "Tanmayee");
            ht.Add("E002", "Vaishanavi");
            ht.Add("E001", "Santosh");
            ht.Add("E007", "Ritesh");
            ht.Add("E005", null);
            ht.Add("E010", "Kajal");
            ht.Add("E008", "Raghav");
            ht.Add("E009", "Ritesh");
            ht.Add("E025", 25);

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }


        }

        public static void Main()
        {
            //  ArrayListEg();
            HashTableEg();
            Console.Read();
        }
    }
}
