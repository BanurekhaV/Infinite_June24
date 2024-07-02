extern alias c1;  //alias names for the assembly
extern alias c2;

using System;
using System.Collections.Generic;
//using ClassLibrary1;
//using ClassLibrary2;

using V1 = c1::ClassLibrary1.Class1;  //alias name for the class of the assembly

using V2 = c2::ClassLibrary2.Class1;

namespace Day14_Dotnet
{
    class ExternAliasEg
    {
        static void Main()
        {
            //c1.ClassLibrary1.Class1 cc1 = new c1.ClassLibrary1.Class1();
            // c1.ClassLibrary1.Class1.x = 1;  fully qualified calls 
            // c2.ClassLibrary2.Class1.x = 2;
            V1.class1Method1();
            V2.class1Method1();

            V1.x = 1;
            V2.x = 2;
            Console.WriteLine(V1.x);
            Console.WriteLine(V2.x);

            //to access non-static members of the class 
            V2 v2 = new V2();
            v2.Method2();
            Console.Read();
        }
    }
}
