using System;
using System.Collections.Generic;


namespace Day9_Dotnet
{
    class DictionaryCollection
    {
        static void Main()
        {           
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Red");
            dict.Add(5, "Violet");
            dict.Add(2, "Indigo");
            dict.Add(4, "Brown");

            foreach(int x in dict.Keys)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            foreach(string s in dict.Values)
            {
                Console.WriteLine(s);
            }

            //inorder to access both the keys as well as the values from the dictiobary object
            //we have to iterate with a KeyValuePair 

            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine("enter Key to retrieve the color");
            int id = Convert.ToInt32(Console.ReadLine());
            if(dict.ContainsKey(id))
            {
                Console.Write(id + " represents " + dict[id]);
            }
            else
                Console.WriteLine("Enter a valid Key");
            
            Console.Read();
        }
    }
}
