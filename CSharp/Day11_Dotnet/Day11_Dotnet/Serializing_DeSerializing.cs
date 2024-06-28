using System;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day11_Dotnet
{
    [Serializable]
    class Serializing_DeSerializing
    {
        public int ID;
        public string Name;

        static void Main()
        {
            //object instantiation and initiliazation using constructor
            // Serializing_DeSerializing sd = new Serializing_DeSerializing();
            // Console.WriteLine(sd.ID + " "+ sd.Name);

            //instantiating objects using object initializer
            Serializing_DeSerializing sd = new Serializing_DeSerializing() { ID = 1, Name = "DotNet Application" };


            //serializing using IFormatter object 
            IFormatter formatter = new BinaryFormatter();
            //or we can create directly an object of BinaryFormatter
            Stream stream = new FileStream(@"C:\Banu\Infinite\Batch_June24\CSharp\Day11_Dotnet\Serialized.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, sd);
            stream.Close();
            Console.ReadKey();
        }

    }
}
