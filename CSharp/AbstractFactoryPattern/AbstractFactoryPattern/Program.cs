using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.AnimalFactory;


namespace AbstractFactoryPattern
{
    class Program
    {
        //public static IAnimal(string atype)
        //{
             
        //}
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory.AnimalFactory animalfactory = null;

            string sound = null;

            //creating respective factory objects
            Console.WriteLine("Enter the Factory Type Land/Sea:");
            string factorytype = Console.ReadLine();
            animalfactory = AnimalFactory.AnimalFactory.CreateAnimalFactory(factorytype);
           // Console.WriteLine("Factory Type Chosen is {0}" , animalfactory.GetType().Name);
            Console.WriteLine();

            //creating animal object
            if(factorytype.Equals("Land"))
            {
                Console.WriteLine("Enter Dog/cat :");
                string reqanimal = Console.ReadLine();
               
                animal=animalfactory.GetAnimal(reqanimal);
                Console.WriteLine("The Chosen Animal is  : {0}", animal.GetType().Name);

                sound = animal.Speak();
                Console.WriteLine($" The Factory is  : {animalfactory}, and the Animal is  : {animal} producing" +
                    $"the sound   : {sound}");              
            }
             else if (factorytype.Equals("Sea"))
            {
                Console.WriteLine("Enter Shark/Octopus :");
                string reqanimal = Console.ReadLine();
                animal = animalfactory.GetAnimal(reqanimal);
              //  Console.WriteLine("The Chosen Animal is {0}", animal.GetType().Name);

                sound = animal.Speak();
                Console.WriteLine($" The Factory is :  {animalfactory}, and the Animal is : {animal} Producing" +
                    $"the sound : {sound}");
            }
            else
                Console.WriteLine("Please choose correct animal");

         
            Console.Read();
        }
    }
}
