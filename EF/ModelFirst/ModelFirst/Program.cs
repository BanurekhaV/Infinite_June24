using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {

        static ModelContainer db = new ModelContainer();
        static void Main(string[] args)
        {
            ShowAllManufacturers();
            Console.WriteLine("-----------CARS-----------");
            AddCars();
            ShowCars();
            Console.Read();
        }

        static void AddCars()
        {
            var car = new Car
            {
                CarName = "Creta",
                CarCost = 2800000,
                ManufacturerMfrId = 1,
            };
            db.Cars.Add(car);
            db.SaveChanges();
        }

        public static void ShowCars()
        {
            var car = db.Cars.ToList();

            foreach(var item in car)
            {
                Console.WriteLine(item.CarId + " "+ item.CarName + " " + item.CarCost);
            }
        }

        static void ShowAllManufacturers()
        {
            var m = db.Manufacturers.ToList();

            foreach(var item in m)
            {
                Console.WriteLine($"{item.MfrId}, {item.MName},{item.CarType}");
            }
        }
    }
}
