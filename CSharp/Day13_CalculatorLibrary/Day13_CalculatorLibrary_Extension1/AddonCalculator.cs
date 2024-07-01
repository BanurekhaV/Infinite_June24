using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day13_CalculatorLibrary;

namespace Day13_CalculatorLibrary_Extension1
{
    public static class AddonCalculator
    {
        public static int MultiplyNos(this CalculatorClass ccobj, int x, int y)
        {
            return x * y;
        }

        public static int DivideNos(this CalculatorClass ccobj, int x, int y)
        {
            return x / y;
        }
    }
}
