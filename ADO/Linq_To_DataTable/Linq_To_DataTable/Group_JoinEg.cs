using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_DataTable
{
    class Person
    {
        public int PId { get; set; }
        public string pName { get; set; }
    }

    class Course
    {
        public int CId { get; set; }
        public string cName { get; set; }
    }
    class Group_JoinEg
    {
        static void Main()
        {
            // Simple_join();
            Sample_GroupJoin();
            Console.Read();
        }

        static void Sample_GroupJoin()
        {
            Person[] p = new Person[]
            {
                new Person{PId= 1, pName="Sam"},
                new Person{PId= 2, pName="Kom"},
                new Person{PId= 2, pName="Rom"},
                new Person{PId= 1, pName="Jam"},
                new Person{PId= 1, pName="Dam"},
                new Person{PId= 3, pName="Ram"},
            };

            Course[] c = new Course[]
            {
                new Course{CId = 1, cName = "Ado.Net"},
                new Course{CId = 2, cName = "C#.Net"},
                new Course{CId = 3, cName = "SQL"}
            };

            var result = c.GroupJoin(p, crs => crs.CId, pers => pers.PId, (cr, ps) => new { key = cr.cName, ps });

            Console.WriteLine("Group-Joined List of Persons who have taken various courses ");

            foreach(var item in result)
            {
                Console.WriteLine(item.key);
             

                foreach (var per in item.ps)
                {
                 
                    Console.WriteLine(per.PId + " " + per.pName);
                }
            }
        }
        static void Simple_join()  //inner joins
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Pakistan", "Japan", "UK", "India", "Korea" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s2);

            Console.WriteLine("Post Joining the strings...");

            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
        }
    }
}
