using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    public delegate void Empdelegate(string s); // declaration of a delegate with a specific signature
    delegate int NumberChanger(int n);
    delegate void Message();
    class Employee
    {
        public static void accept(string name)
        {
            Console.WriteLine("Hello "+ name);
        }

        public void display(string str)
        {
            Console.WriteLine(str);
        }

        public void ShowEmp()
        {
            Console.WriteLine("Hello All Employees"); 
        }
               
    }

    class Numbers
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void Showmessage()
        {
            Console.WriteLine("Hi, Welcome to delegates .."); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the implementing class
            Employee emp = new Employee();

            //creating objects of the delegate
            Empdelegate ed1 = new Empdelegate(Employee.accept); //assigning the name of the static function/method to the delegate object
           
            Empdelegate ed2 = new Empdelegate(emp.display); //assigning the name of the non-static function/method to the delegate object
            //now let us invoke the delegate
            ed1.Invoke("Amanullah");
            ed2("This is a class on Delegates");
            Console.WriteLine("--------- Example 2 Delegates ----------");
            NumberChanger nc1 = new NumberChanger(Numbers.AddNum);
            NumberChanger nc2 = new NumberChanger(Numbers.MultiplyNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num :{0}", Numbers.getNum());
            nc2(5);
            Console.WriteLine("Value of Num :{0}", Numbers.getNum());

            Console.WriteLine("---------- Multicasting of delegates ---------");
            //multicasting of delegates
            Message mdel1 = new Message(Numbers.Showmessage);
            Message mdel2 = new Message(emp.ShowEmp);
            Message mdel = mdel1 + mdel2; //multicasting 
            mdel();
            Console.Read();

        }
    }
}
