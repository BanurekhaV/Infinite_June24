using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2.ConcreteClasses
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports Car Details .");
        }
    }
}
