using System;
namespace Exercise_11
{
    class RunClass
    {


        public static void Main(string[] args)
        {
            Program program = new Program();
            int[] ArrayClump = { 1, 1, 1, 1, 1 };
            Console.WriteLine(program.CountClumps(ArrayClump));
        }
    }
}