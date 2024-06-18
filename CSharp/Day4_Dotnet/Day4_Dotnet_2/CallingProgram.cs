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
        }
    }
}
