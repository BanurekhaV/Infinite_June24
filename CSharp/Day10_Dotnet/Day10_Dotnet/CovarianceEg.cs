using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    public class Person { }
    public class Employees : Person { }
    public class Manager : Employees { }

    delegate Person Persondelegate(Employees emp);
    class CovarianceEg
    {
        static void Main()
        {
            var personobj = new Person();
            var empobj = new Employees();
            var mgrobj = new Manager();

            //covariance -
            //assigning more derived employee/Manager object to a lesser derived personobject
            personobj = empobj; //or
           // personobj = new Employees();
          //  personobj = mgrobj;
           // empobj = mgrobj;

           // empobj =(Employees) personobj;  //compiler error as it is not implicit, we need to typecast
            //contravariance

            Persondelegate pd = GreetingPerson;  //contravariance
            Console.WriteLine(pd((Employees)personobj)); 

                      
            Console.Read();
        }

        static Person GreetingPerson(Person p)
        {
            Console.WriteLine("Hello and Welcome Mr/Ms " + p);
            return p;
        }
    }

    
}
