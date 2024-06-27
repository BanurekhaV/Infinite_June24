using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    public delegate string EventDelegate(string str);

    class Events_1   // publisher class
    {
        //declare an event
        event EventDelegate ourEvent;  // declaring an event for a delegate

        event EventDelegate secondevent;

        public Events_1()
        {
            this.ourEvent += new EventDelegate(this.WelcometheUser);
            this.secondevent += new EventDelegate(this.Someotherfunction);
            this.secondevent += new EventDelegate(EventSubscriber.Handlerfunction); //event handler in other class than the publisher
        }

        public string WelcometheUser(string uname)
        {
          //  Console.WriteLine("Welcome User : "+ uname);
            return "Welcome User :  " + uname;
        }

        public string Someotherfunction(string s)
        {
            return s + " " + "Hope you are enjoying the session";
        }

        public static void Main()
        {
            Events_1 eventobj = new Events_1();
            //1. calling the function with th ehelp of the object
            string r1= eventobj.WelcometheUser("hi");
            Console.WriteLine(r1);

           //2. calling functions thru delegates
            EventDelegate ed = eventobj.WelcometheUser;
            string res = ed("Hello");
            Console.WriteLine(res);
            
          
            //3. calling functions thru delegates of the event
            string result = eventobj.ourEvent("Infinite Associates");  //raising the ourEvent
            Console.WriteLine(result);

            string secondresult = eventobj.secondevent("Infinite Assocaiates"); //raising secondevent
            Console.WriteLine(secondresult);
            Console.Read();
        }
    }

    class EventSubscriber
    {
        public static string Handlerfunction(string str)
        {
            return "This is the data in the argument " + str;
        }
    }
}
