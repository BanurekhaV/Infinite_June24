using System;

namespace Day1_Dotnet
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C Sharp classes..");
            Console.WriteLine("Please Enter Your FirstName :");
            string fname = Console.ReadLine();
            Console.WriteLine("Please Enter Your LastName :");
            string lname = Console.ReadLine();
            Console.WriteLine("Your First Name is :" + fname + " and LastName is " + lname);  //concatenation
            Console.WriteLine("your First Name is :{0}, and Last Name is :{1}", fname,lname); //placeholder substitution
            Console.WriteLine($"Your FirstName is {fname} and Lastname is {lname}"); //string interpolation
             //to call a non-static function, 
             //we need to have an object
            MyClass myclass = new MyClass();
            myclass.Display("Banurekha");
            //to call a static function of the class, we dont need an object
            int sum = Addnos(5, 5);
            Console.WriteLine("The total is " + sum);
            Console.Read();
        }

        void Display(string username)  //function signature or declaration
        {
            Console.WriteLine("Welcome  " + username); //function definition/body/implementation
        }

        static int Addnos(int num1, int num2)
        {
            return num1 + num2;
        }
    }
        
}
