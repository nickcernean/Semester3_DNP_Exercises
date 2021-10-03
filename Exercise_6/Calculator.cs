using System;

namespace MathLib
{

    public class Calculator
    {
        public Calculator()
        { }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] Sum)
        {
            int Result=0;
            foreach (int i in Sum)
            {
                Sum[i]=+Result;
            }
            return Result;
        }
        public void MaximumNumber(int a, int b)
        {
            Console.WriteLine("Input first comparison number: ");
            a = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Input second comparison number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The maximum is: " + Math.Max(a, b));
        }
    }
}