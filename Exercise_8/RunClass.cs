using System;
namespace Exercise_8
{

    class RunClass
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.MakeOutWord("{{}}", "hello"));
        }
    }
}