using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_SumsAndQuestionsmarks
{
    class RunClass
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Console.WriteLine(pr.GenerateRandomString(20));
            Console.ReadLine();
        }
    }
}