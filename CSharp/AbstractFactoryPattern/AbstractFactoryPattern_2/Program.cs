using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern_2.ConcreteClasses;

namespace AbstractFactoryPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for all regular vehicles
            IVehicleFactory regularfactory = new RegularVehicleFactory();

            IBike regularbike = regularfactory.CreateBike();
            regularbike.GetDetails();

            ICar regularcar = regularfactory.CreateCar();
            regularcar.GetDetails();

            //for all sports vehicle
            IVehicleFactory sportsfactory = new SportsVehicleFactory();

            IBike sportsbike = sportsfactory.CreateBike();
            sportsbike.GetDetails();

            ICar sportscar = sportsfactory.CreateCar();
            sportscar.GetDetails();

            Console.Read();
        }
    }
}
