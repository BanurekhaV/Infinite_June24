using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{
    class Enumerable_enumerator
    {
        static void Main()
        {
            List<string> Colors = new List<string>()
            {
                "Red", "Blue","Green","Yellow","White","Black","Orange","Pink"
            }; //or

            foreach(var c in Colors)
            {
                Console.WriteLine(c);
            }
            //how to iterate the collection using IEnumerable

            //  IEnumerable<string> enumerableColors =(IEnumerable<string>) Colors;

            IEnumerable<string> enumerableColors = Colors;

            foreach(string c in enumerableColors)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("---------IEnumerator Usage--------");
            //let us now use IEnumerator
            IEnumerator<string> enumeratorColors = Colors.GetEnumerator(); // to convert List to IEnumerator.
            //we can now invoke the GetEnumerator() 
            //to retrieve all the items/elements from the above IEnumerator, we cannot use a foreach loop
            //instead we have to use the boolean MoveNext() 

            while(enumeratorColors.MoveNext())
            {
                Console.WriteLine(enumeratorColors.Current);
            }
            Console.Read();
        }

    }
}
