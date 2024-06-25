using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{
    class GenericIndexers<T>
    {
        T[] data = new T[3];
        T var1;
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public T Var1
        {
            get { return var1; }
            set { var1 = value; }
        }

        //generic indexer for 'data' field
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //let us overload the indexer for data field
        //1.
        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        //2. 
        public T this[string index]
        {
            get { return data[1]; }
            set { data[1] = value; }
        }
    }

    class TestIndexer
    {
        static void Main()
        {
            GenericIndexers<float> genericindexerf = new GenericIndexers<float>();
            genericindexerf[0.0f] = 5.5f;
            genericindexerf[1.0f] = 10.5f;
            genericindexerf[2.0f] = 15.5f;
            genericindexerf.Var1 = 20.5f;
            genericindexerf.Name = "I am not a generic member";

            //the below will call the get indexer
            Console.WriteLine("At Position 1 " + " " + genericindexerf[0.0f]);
            Console.WriteLine("At Position 2 " + " " + genericindexerf[1.0f]);
            Console.WriteLine("At Position 3 " + " " + genericindexerf[2.0f]);

            //the below will call the get property
            Console.WriteLine("Variable value" + " " + genericindexerf.Var1);
            Console.WriteLine("Non Generic members value is "+ " " + genericindexerf.Name);

            Console.WriteLine("========================");
            GenericIndexers<string> genericindexers = new GenericIndexers<string>();
            genericindexers["0"] = "AAA";
            genericindexers["1"] = "BBB";
            genericindexers["2"] = "CCC";
            genericindexers.Var1 = "Hello Kitty";
            genericindexers.Name = "I am not a generic member";

            //the below will call the get indexer
            Console.WriteLine("At Position 1 " + " " + genericindexers["0"]);
            Console.WriteLine("At Position 2 " + " " + genericindexers["1"]);
            Console.WriteLine("At Position 3 " + " " + genericindexers["2"]);

            //the below will call the get property
            Console.WriteLine("Variable value" + " " + genericindexers.Var1);
            Console.WriteLine("Non Generic members value is " + " " + genericindexers.Name);

            Console.Read();
        }
    }
}
