using System;
using Day4_Dotnet;

namespace Day4_Dotnet_2
{ 
    class CallingProgram : Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.fvar = 500.55f; // public member of the other class, accessed using an object of the class
            Program.s = "hh";  // static public member of the other class accessed using the classname
            //cannot access any internal members of the other assembly
            
            CallingProgram cp = new CallingProgram();
            cp.pt = 18;
            cp.ip = 15;

            Console.WriteLine("First Statement");

            goto infinite;
            Console.WriteLine("Second Statement");
            Console.WriteLine("Third Statement");

        infinite:
            Console.WriteLine("Infinite Welcomes all new associates..");
            goto label1;
           
            Console.WriteLine("You have reached Label 1");

            Console.WriteLine("Will see you!..");

        label1:
            Console.WriteLine("Bye..");

        doagain:
            Console.WriteLine("Enter a number less than 10");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num >=10)
            {
                Console.WriteLine("Number should be less than 10 only");
                goto doagain;
            }

            Console.WriteLine(num + " is less than 10");
            Console.Read();
        }
    }
}
