using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class IndexersEg1
    {
        public int Code { get; set; }
        string[] colors = new string[3];

        public void setcolors()
        {
            for(int i=0;i<3;i++ )
            {
                colors[i] = Console.ReadLine();
            }
        }

        //indexer decl for colors
        public string this[int flag]
        {
            //accessing the array element
            get
            {
                return colors[flag];
            }
            //for seetimg data into an element of the array
            set
            {
                colors[flag] = value;
            }
        }

    }

    class IndexersEg2
    {
        string[] days = { "Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat" };

        //ties to find the given day and returns the day if found else exception
     public int GetDay(string day)
        {
            for (int i=0; i<days.Length; i++)
            {
                if(days[i]==day)
                {
                    return i;
                }
            }
            Console.WriteLine("Day must be in the form of \"Sun\", \"Mon\", etc");
            return 0;
        }

        public int this[string day]
        {
            get
            {
                return (GetDay(day));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexersEg1 indexer = new IndexersEg1();
            indexer.Code = 10; // setting property value of a field that can take one data
            //indexer[0] = "Red";  //value will be set to colors[0]
            //indexer[1] = "Blue";
            //indexer[2] = "Green";
            indexer.setcolors();
            Console.WriteLine(indexer[0] + " " + indexer[1]);
            Console.WriteLine("-------------------");
            IndexersEg2 ind2 = new IndexersEg2();

            Console.WriteLine(ind2["Thur"]);
            Console.WriteLine(ind2.GetDay("Fri"));
            Console.Read();
        }
    }
}
