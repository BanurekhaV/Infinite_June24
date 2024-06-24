using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_DotNet
{
    //let us create a class for user defined exception

    class VotingException : ApplicationException
    {
        public VotingException(string msg) 
        { }
    }

    //let us create a class that raises the above exception if needed

    class Vote
    {
        int age;

        public void GetAge()
        {
            Console.WriteLine("Enter your Age to Vote :");
            age = Convert.ToInt32(Console.ReadLine());

            //this is the place decided to create and throw the exception object
            if(age < 18)
            {
                throw (new VotingException("Age Should be greater than 18 to Vote."));
            }
            else
                Console.WriteLine("Thanks for Voting...");
        }

    }
    class UserDefinedException
    {
        public static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.GetAge();
            }
            catch (VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some Error Occurred. Try after sometime" + " "+ e.Message);
            }

          //  Console.WriteLine(Checked_Unchecked.CheckIntOverflow());
            Console.WriteLine(Checked_Unchecked.UncheckIntOverflow());
            Console.Read();
        }
    }

    class Checked_Unchecked
    {
        static int maxint = 2147483647;

        //checked expression
        public static int CheckIntOverflow()
        {
            int x = 0;
            try
            {
                x = checked(maxint + 10); //this line will raise an exception
            }
            catch(OverflowException oe)
            {
                Console.WriteLine("Checked : " + oe.ToString());
            }
            return x;
        }

        public static int UncheckIntOverflow()
        {
            int x = 0;
            try
            {
                x = maxint + 10;
            }
            catch(OverflowException oe)
            {
                Console.WriteLine("Unchecked : " + oe.ToString());
            }

            return x;  // overflow is suppressed
        }
    }
}
