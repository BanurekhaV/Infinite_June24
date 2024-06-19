using System;


namespace Day5_Dotnet
{
    public class Account
    {
        public int Id;
        public string Name;
        public static float rateofint;

        //instance constructor
        public Account(int id, string name)
        {
            Id = id;
            Name = name;
           // rateofint = 6.5f;
        }

        //static constructors initializes the static members
         static Account()
        {
            rateofint = 7.5f;
        }

        public void Display()
        {
            Console.WriteLine(Id + " " + Name + " " + rateofint);
        }
    }
    class StaticConstructorEg
    {

        public static void Main()
        {
            Account a1 = new Account(1001, "Shashank");
            Account a2 = new Account(3345, "Swapna");
            a1.Display();
            a2.Display();
            Console.Read();
        }
    }
}
