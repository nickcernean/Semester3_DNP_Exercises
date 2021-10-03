using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_SumsAndQuestionsmarks
{
    class Program
    {
        public Program()
        {

        }
        
        public string GenerateRandomString(int length)
        { 
            // Numbers in ASCII from: 48 to 57;
            // Low case letter from:  97 to 122;
            // question mark: 63
            Random Random = new Random();
            const string Chars= "abcdefghijklmnopqrstuvwxyz0123456789?????????";
            return new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        public int FindSums(string s)
        {

            return 0;

        }

    }
}