using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class RunClass
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();


            Console.WriteLine(calculator.Add(3, 5));
            int[] IntegersToSum = { 1, 4, 6, 7, 10, 43 };
            Console.WriteLine(calculator.Add(IntegersToSum));
            calculator.MaximumNumber(10, 15);
            Console.ReadLine();
        }
    }
}