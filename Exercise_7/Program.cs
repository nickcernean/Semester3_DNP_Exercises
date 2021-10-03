using System;
namespace Exercise_7
{
    public class Program
    {

        public Program()
        {

        }
        public string AbbaMethodConcatenation(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);
        }
    }
}