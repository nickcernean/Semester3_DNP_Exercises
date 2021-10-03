using System;
using System.Linq;
namespace Exercise_8
{
    class Program
    {
        public Program()
        {

        }
        public string MakeOutWord(string a, string b)
        {

            if (a.Length.Equals(4))
            {
                var Chars = a.ToCharArray(0, 4);
                var FormattedString = string.Format("{0}{1}{2}{3}{4}", Chars[0], Chars[1], b, Chars[2], Chars[3]);
                return FormattedString;
            }
            return "Surrounder must have 4 characters !";
        }

    }

}