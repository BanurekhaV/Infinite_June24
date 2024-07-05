using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.ConcreteClasses;

namespace AbstractFactoryPattern.AnimalFactory
{
    class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animaltype)
        {
            if (animaltype.Equals("Shark"))
            {
                return new Shark();
            }
            else if (animaltype.Equals("Octopus"))
            {
                return new Octopus();

            }
            else return null;
        }

      
    }
}
