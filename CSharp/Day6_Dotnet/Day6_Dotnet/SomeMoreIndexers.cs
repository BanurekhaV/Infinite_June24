using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    public class Flowers
    {
        string Name;
        string Color;

        //constructor
        public Flowers(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public void DisplayFlowers()
        {
            Console.WriteLine(Name  + " " + "are " + Color + " in Color ");
        }
    }
    class FlowerVase
    {
        Flowers[] flowerobject = new Flowers[5];  //composition/aggregation representing has a relationship
                                                  //Flowervase class contains Flowers object

        //indexer to set and get the data of the flower object
        public Flowers this[int pos]
        {
            get { return flowerobject[pos]; }
            set { flowerobject[pos] = value; }
        }

        public static void Main()
        {
            FlowerVase fv = new FlowerVase();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Name of a Flower :");
                string f = Console.ReadLine();
                Console.WriteLine("Enter Color of the flower :");
                string c = Console.ReadLine();
                fv[i] = new Flowers(f, c);
            }

            for (int i = 0; i < 5; i++)
            {
                fv[i].DisplayFlowers();
            }
            Console.Read();
        }
    }
}
