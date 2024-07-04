using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Implementingclasses;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the Credit Card :");
            string cardname = Console.ReadLine();

            CreditCard cc = null;
            if (cardname == "MoneyBack") 
            {
                cc = new MoneyBack();
            }
            else if(cardname == "Platinum") 
            {
                cc = new Platinum();
            }
            else if(cardname == "Titanium") 
            {
                cc = new Titanium();
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            if(cc !=null)
            {
                Console.WriteLine("Card Type : " + cc.GetCardType());
                Console.WriteLine("Card Limit : " + cc.GetCardLimit());
                Console.WriteLine("Annual Charges :"+ cc.GetAnnualCharges());
            }
            Console.Read();
        }
    }
}
