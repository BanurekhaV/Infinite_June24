using System;
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

            Console.WriteLine(arrlst1.Count + " " + arrlst1.Capacity);

            foreach (var item in arrlst1)
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

            Console.WriteLine("-----------------");
            //in order to get both the keys and values

            foreach (DictionaryEntry de in ht)
            {
                Console.Write(de.Key + " ");
                Console.Write(de.Value);
                Console.WriteLine();
            }
            Console.WriteLine("Searching.............a record");
            Console.WriteLine("Enter a Key to search :");
            string ekey = Console.ReadLine();
            if (ht.ContainsKey(ekey))
            {
                Console.WriteLine(ekey + " = " + ht[ekey]);
            }
            else
                Console.WriteLine(ekey + " does not exists");
        }

        public static void Others()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "Visual basic");
            sl.Add("cs", "CSharp");
            sl.Add("asp", "ASP Net");

            foreach(DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            Console.WriteLine("--------------------");

            Stack st = new Stack();
            st.Push(100);
            st.Push("AAAA");
            st.Push(400);

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }

             st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st.Peek());
            Console.WriteLine("=================");
            Queue q = new Queue();
            q.Enqueue("CSharp.Net");
            q.Enqueue("VB.Net");
            q.Enqueue("ASP.Net");
            q.Enqueue("ADO.Net");

            foreach(Object o in q)
            {
                Console.WriteLine(o);
            }

            q.Dequeue();
            foreach (Object o in q)
            {
                Console.WriteLine(o);
            }
        }

        public static void Main()
        {
            //  ArrayListEg();
            //HashTableEg();
            Others();
            Console.Read();
        }
    }
}
