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
        //program 1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter name of the Credit Card :");
        //    string cardname = Console.ReadLine();

        //    ICreditCard cc = null;
        //    if (cardname == "MoneyBack") 
        //    {
        //        cc = new MoneyBack();
        //    }
        //    else if(cardname == "Platinum") 
        //    {
        //        cc = new Platinum();
        //    }
        //    else if(cardname == "Titanium") 
        //    {
        //        cc = new Titanium();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Card Type");
        //    }
        //    if(cc !=null)
        //    {
        //        Console.WriteLine("Card Type : " + cc.GetCardType());
        //        Console.WriteLine("Card Limit : " + cc.GetCardLimit());
        //        Console.WriteLine("Annual Charges :"+ cc.GetAnnualCharges());
        //    }
        //    Console.Read();
        //}

        //implementing Factory Pattern and hence client code will be as follows
        static void Main()
        {
            Console.WriteLine("Enter name of the Credit Card :");
            string cardname = Console.ReadLine();
            ICreditCard ccard =  CreditCardFactory.GetCardInfo(cardname);

            if (ccard != null)
            {
                Console.WriteLine("Card Type : " + ccard.GetCardType());
                Console.WriteLine("Card Limit : " + ccard.GetCardLimit());
                Console.WriteLine("Annual Charges :" + ccard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.Read();

        }
    }
}
