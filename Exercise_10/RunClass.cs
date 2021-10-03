using System;
namespace Exercise_10
{

    class RunClass
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            int[] ArraysBigDifference = { 13, 21, 4, 21, 321, 212, 412 };
            program.BigDiff(ArraysBigDifference);
            Console.WriteLine("Biggest difference: "+program.BigDiff(ArraysBigDifference));
        }

    }   

}