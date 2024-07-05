using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bow Bow";
        }
    }
}
