using System;
using System.Collections.Generic;
using System.IO;

namespace Day11_Dotnet
{
    class Files_Eg1
    {
        static void Main()
        {
            // WriteBinary();
            // ReadBinary();
            FilesEg2 file2 = new FilesEg2();
            file2.WriteData();
            file2.ReadData();
            Console.Read();
        }
        static void WriteBinary()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Banu\\Infinite\\Batch_June24\\binfile.bin", FileMode.Create)))
            {
                //let us write now
                writer.Write("0x802348904");
                writer.Write(true);
                writer.Write("Windows Binary File");
            }
        }

        static void ReadBinary()
        {
            using(BinaryReader reader = new BinaryReader(File.Open("C:\\Banu\\Infinite\\Batch_June24\\binfile.bin",FileMode.Open)))
            {
                Console.WriteLine("Address Code : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                Console.WriteLine("Message : " + reader.ReadString());
            }
        }
    }

    class FilesEg2
    {
        public void ReadData()
        {
            FileStream fs = new FileStream(@"C:\Banu\Infinite\Batch_June24\Myfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            /*we can position the file pointer at any location by seeking no,
             * of bytes. But here we want to position it from the beginning*/
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string str = sr.ReadLine();

            while(str != null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        public void WriteData()
        {
            FileStream fs = new FileStream(@"C:\Banu\Infinite\Batch_June24\Myfile.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            //prompt the user for data to write
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            sw.Write(str);

            sw.Flush(); //clears the buffer of the current writer
            sw.Close(); //closes the current streamwriter object
            fs.Close(); //closes the stream itself
        }
    }
}
