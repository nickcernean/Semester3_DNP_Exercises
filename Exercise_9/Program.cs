using System;
using System.Linq;
namespace Exercise_9
{
    class Program
    {
        public Program()
        {

        }
        public string nTwice(string a, int b)
        {
            string FormattedString = a.Substring(0, b);
            string FormattedString2 = a.Substring(a.Length - (b), b);
            return string.Concat(FormattedString, FormattedString2);
        }


    }
}