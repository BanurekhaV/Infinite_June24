using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementingclasses
{
    class MoneyBack : ICreditCard
    {
        public int GetAnnualCharges()
        {
            return 500;
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
