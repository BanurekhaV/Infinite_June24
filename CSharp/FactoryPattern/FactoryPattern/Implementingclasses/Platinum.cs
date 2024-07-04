using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementingclasses
{
    class Platinum : ICreditCard
    {
        public int GetAnnualCharges()
        {
            return 1000;
        }

        public int GetCardLimit()
        {
            return 20000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }
    }
}
