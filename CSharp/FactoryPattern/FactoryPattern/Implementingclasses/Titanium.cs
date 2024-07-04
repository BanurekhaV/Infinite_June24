using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementingclasses
{
    class Titanium : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 1500;
        }

        public int GetCardLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }
    }
}
