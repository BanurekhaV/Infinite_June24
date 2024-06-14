using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class Decisionmaking
    {
        public void CheckGrade()
        {
            char grade;
            int mathscore=85;
            Console.Write("enter your grade:  ");
            grade = Convert.ToChar(Console.ReadLine());
            if(grade =='O' || grade == 'o' && mathscore > 75)
                Console.WriteLine("Outstanding");
            else if(grade == 'A' || grade == 'a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Can improve");
            else
                Console.WriteLine("Invalid Grade");
        }

        public void CheckGradeWithSwitch()
        {
            
            Console.WriteLine("Enter your Grade");
            char grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'O':
                case 'o':
                   Console.WriteLine("Outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("can improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }

    class Loops
    {
        public void WhileLoop()
        {
            int i = 1; 
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int total = 0;
            for(int i=1; i<=5;i++)
            {
                if (i == 3)
                    // break;
                    continue;
                total += i;               
            }
            Console.WriteLine("Sum of all numbers {0}", total);
        }

        public void ImplicitTypeExample()
        {
            char c;  //declaring a variable of character type
            int x; //decl
            float f;
            Program p;
            var mydata = "abx";  // implicitly typed variable
            Console.WriteLine(mydata);

            dynamic d;  // a reference type
            d = 6;
            d = 'b';
            d = "hello";
            d = 12345678.4567;
            Console.WriteLine(d);

        }
    }
}
