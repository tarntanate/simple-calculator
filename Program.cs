using System;
using System.Data;
using System.Linq;

namespace calcutator_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "(22*2) + 50"; // Result: 94
            string input2 = "((2*3+12) / 2)"; // Result: 9 (not 15)
            string input3 = "(10-5+3/2*2)"; // Result: 8
            string input4 = "(1+2+3+4+5*2/2*3)"; // Result: 25

            Console.WriteLine(input1 + " = " + Calculator.Calc(input1)); // 94
            Console.WriteLine(input2 + " = " + Calculator.Calc(input2)); // 9
            Console.WriteLine(input3 + " = " + Calculator.Calc(input3)); // 8
            Console.WriteLine(input4 + " = " + Calculator.Calc(input4)); // 25
        }
    }

    class Calculator
    {
        public static double Calc(string input)
        {
            return Convert.ToDouble(new DataTable().Compute(input, null));
        }
    }
}
