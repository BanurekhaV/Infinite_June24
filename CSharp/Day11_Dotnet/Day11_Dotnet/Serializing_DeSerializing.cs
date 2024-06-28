using System;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day11_Dotnet
{
    [Serializable]    //Annotation/Attribute/Mata Data
    class Serializing_DeSerializing
    {
        public int ID;
        public string Name;
        [NonSerialized]    
        public string Password;

        static void Main()
        {
            //object instantiation and initiliazation using constructor
            // Serializing_DeSerializing sd = new Serializing_DeSerializing();
            // Console.WriteLine(sd.ID + " "+ sd.Name);

            //instantiating objects using object initializer
            Serializing_DeSerializing sd = new Serializing_DeSerializing() { ID = 1, Name = "DotNet Application" , Password="Admin@123"};

            Console.WriteLine($"ID is {sd.ID}, Name is {sd.Name} and Password is {sd.Password}");
            //serializing using IFormatter object 
            IFormatter formatter = new BinaryFormatter();
            //or we can create directly an object of BinaryFormatter
            Stream stream = new FileStream(@"C:\Banu\Infinite\Batch_June24\CSharp\Day11_Dotnet\Serialized.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, sd);
            stream.Close();

            Console.WriteLine("-----Deserialized data----");
            stream = new FileStream(@"C:\Banu\Infinite\Batch_June24\CSharp\Day11_Dotnet\Serialized.txt", FileMode.Open, FileAccess.Read);
            Serializing_DeSerializing dobj = (Serializing_DeSerializing)formatter.Deserialize(stream);
            Console.WriteLine(dobj.ID + " " + dobj.Name + " " + dobj.Password);
            Console.ReadKey();
        }

    }
}
