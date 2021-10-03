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
            int Result = 0;
            foreach (int i in Sum)
            {
                Result =+Sum[i];
            }
            return Result;
        }
    }
}