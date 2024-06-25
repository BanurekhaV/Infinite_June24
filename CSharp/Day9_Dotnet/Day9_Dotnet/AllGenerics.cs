using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{
    class CompleteGenerics<T>      //where T : class   // constraint to generic class
    {
        private T genericMemberVariable;

        public CompleteGenerics(T val)
        {
            genericMemberVariable = val;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type is : {0}, Value is :{1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type is :{0}, and Value is :{1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
    }
    class AllGenerics
    {

        public static void Main()
        {
            //instantiating the generic class with integer type
            CompleteGenerics<int> cgi = new CompleteGenerics<int>(100);

            //calling the generic method with int argument
            int retval = cgi.genericMethod(200);
            Console.WriteLine(retval + " was the return type with integer instance");

            CompleteGenerics<string> cgs = new CompleteGenerics<string>("Hi Generics");
            string result = cgs.genericMethod("Trying to Learn Generics of C#");
            Console.WriteLine(result + " was the return type with string instance");

            Console.WriteLine("-----------Example 2------------");
            GenericsEg_2<int> intobj = new GenericsEg_2<int>();

            //add values into the aarray
            intobj.Addelement(2);
            intobj.Addelement(4);
            intobj.Addelement(6);     // there will be no boxing/conversion etc.
            intobj.Addelement(8);
            intobj.Addelement(10);

            //display the array elements

            for(int i=0; i<5;i++)
            {
                Console.WriteLine(intobj[i]);  //no boxing/conversion needed
            }

            Console.Read();
        }
    }

    public class GenericsEg_2<T>
    {
        //define an array of generic type
        T[] obj = new T[5];
        int count = 0;

        //create a method to add elements into the array
        public void Addelement(T item)
        {
            if(count < 5)
            {
                obj[count] = item;
            }
            count ++;
        }

        //indexer 
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }

    }


}
