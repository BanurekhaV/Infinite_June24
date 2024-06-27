using System;
using System.Collections.Generic;
using System.IO;


namespace Day11_Dotnet
{
    class UsingBlock
    {
        public static void Main()
        {
               string manylines = "This is Line no :1" +
                "This is Line two, and" +
                "this is line 3, and we have the" +
                "last line";

            //let us read the data from the above string using some reader classes
            using(var reader = new StringReader(manylines))
            {
                string finaldata;
                do
                {
                    finaldata = reader.ReadLine();
                    Console.WriteLine(finaldata);
                } while (finaldata != null);
            }

            using (var streamreader = new StreamReader(@"C:\Banu\Infinite\Batch_June24\Basics.txt"))
            {
                Console.WriteLine(streamreader.ReadToEnd());
            }
            Console.Read();
        }
    }
}
