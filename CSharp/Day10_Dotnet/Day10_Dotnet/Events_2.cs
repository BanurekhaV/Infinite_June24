using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class Events_2
    {
        int data = 5;

        //decl delegate
        public delegate void NumberManipulator(int x);

        //decl event
        public event NumberManipulator ChangeNumberEvent;

        public Events_2(int n)
        {
            this.ChangeNumberEvent += new NumberManipulator(this.onChangeNum); //registering an event with the delegate and hence a function
            setValue(n);
        }

        public void onChangeNum(int x)  //event handler
        {
            Console.WriteLine($"Event Raised and the value fron {data} changed to {x}");
        }

        public void setValue(int n)  //responsible for raising an event
        {
            if(data != n)   // when the field data's value and the input value n are different
            {
                ChangeNumberEvent(n);  // we are actually raising the event
            }
            else
            { 
                Console.WriteLine("No changes in the value.. and hence no event/notification"); 
            }
        }
    }

    class TestEvent
    {
        static void Main()
        {
            Events_2 eobj = new Events_2(5);  // no event
            eobj.setValue(10);  // event is raised
            eobj.setValue(20);  // event is raised
            eobj.setValue(5); // no event

            Console.Read();

        }
    }
}
