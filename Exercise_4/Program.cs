using System;
using System.Collections;
namespace Exercise_4
{
    class Program
    {
        private ArrayList Numbers;
        public Program()
        {
            Numbers = new ArrayList();
        }
        public ArrayList AllEvenNumbers(int x)
        {
            ArrayList EvenNumbers = new ArrayList();
            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    EvenNumbers.Add(i);
                }
            }
            return EvenNumbers;
        }
        public ArrayList AllUnevenNumbers(int x)
        {
            ArrayList UnevenNumbers = new ArrayList();
    
            foreach (int i in Numbers)
            {
                if (i % 2 != 0)
                {
                    UnevenNumbers.Add(i);
                }
               
            }
            return UnevenNumbers;
        }
        public ArrayList AllDivisibleNumbersBy(int x, int y)
        {
            ArrayList DivisibleNumbers = new ArrayList();
            foreach (int i in Numbers)
            {
                if (i % y == 0)
                {
                    DivisibleNumbers.Add(i);
                }
            }
            return DivisibleNumbers;
        }
    }


}