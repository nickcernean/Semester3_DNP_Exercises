using System;
using System.Linq;   
namespace Exercise_10
{
    public class Program
    {
        public Program()
        {

        }

        public int BigDiff(int[] ArrayNumbers)
        {

            return ArrayNumbers.Max() - ArrayNumbers.Min();
        }
    }

}