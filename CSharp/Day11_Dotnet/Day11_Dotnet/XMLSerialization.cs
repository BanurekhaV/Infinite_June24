using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Day11_Dotnet
{
    public class Books
    {
        public string authorname;
        public string bookname;
        public int yr_published;

        public Books() { }

        public Books(string aname, string bname, int yr)
        {
            authorname = aname;
            bookname = bname;
            yr_published = yr;
        }
    }
    class XMLSerialization
    {
        public static void Main()
        {
            Books book = new Books("Amish Tripathi", "Seetha - the Warrior of Mithila", 2010);

            //xml serialization
            XmlSerializer xmlser = new XmlSerializer(typeof(Books));

            StreamWriter writer = new StreamWriter("Books.xml");  // target for serializing

            xmlser.Serialize(writer, book);
            writer.Close();

            //deserializing

            Books b1 = new Books();
            //  XmlSerializer x1 = new XmlSerializer(typeof(Books));
            StreamReader reader = new StreamReader("Books.xml");
            b1 = (Books)xmlser.Deserialize(reader);
            reader.Close();
            Console.WriteLine($"BookName : {b1.bookname}, AuthorName : {b1.authorname} and Year of Publish : {b1.yr_published}");
            Console.Read();
        }
    }

    
}
