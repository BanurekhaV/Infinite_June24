using System;
using System.Collections.Generic;
using System.IO;

namespace Day11_Dotnet
{
    class File_n_Dir_Info
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Banu\Infinite\Batch_June24\SampleDir");
            if(dirinfo.Exists)
            {
                Console.WriteLine("Directory already exists..");
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory Created");
            }
            Console.WriteLine("-------- Directories ----------");
            //let us now iterate existing directory with sub directories and files
            DirectoryInfo mydir = new DirectoryInfo(@"C:\Banu\Infinite\Batch_June24\CSharp");

            //check for existence, and get all subdirectories
            if(mydir.Exists)
            {
                DirectoryInfo[] dirs = mydir.GetDirectories();

                foreach(object dirobj in dirs)
                {
                    Console.WriteLine(dirobj.ToString());
                }
            }
            else
                Console.WriteLine("Given Directory does not exists");
            Console.WriteLine("----- List of Files in the directory -----");
            //now let us get the files in the directory
            FileInfo[] files = mydir.GetFiles();

            foreach(FileInfo fi in files)
            {
                Console.WriteLine("File Name : {0}  Size : {1}  ExtensionType : {2}", fi.Name, fi.Length, fi.Extension);
            }
            Console.Read();
        }
    }
}
