using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AnimalFactory
{
   public abstract class AnimalFactory
    {
        //abstract method
        public abstract IAnimal GetAnimal(string animaltype);
        
        //non abstract method
        public static AnimalFactory CreateAnimalFactory(string factorytype)
        {
            if (factorytype.Equals("Land"))
            {
                return new LandAnimalFactory();
            }
            else if (factorytype.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
                return null;
        }
        
    }
}
