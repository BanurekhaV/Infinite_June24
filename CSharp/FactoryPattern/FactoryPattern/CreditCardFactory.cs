using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Implementingclasses;

namespace FactoryPattern
{
     public class CreditCardFactory
    {
         public static ICreditCard GetCardInfo(string ctype)
        {
            ICreditCard cc = null;
            if (ctype == "MoneyBack")
            {
                cc = new MoneyBack();
            }
            else if (ctype == "Platinum")
            {
                cc = new Platinum();
            }
            else if (ctype == "Titanium")
            {
                cc = new Titanium();
            }
            
            return cc;
        }
    }
}
