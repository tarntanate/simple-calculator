using System;
using System.Data;

namespace calcutator
{
    class Calculator
    {
        public static double Calc(string input)
        {
            return Convert.ToDouble(new DataTable().Compute(input, null));
        }
    }
}
