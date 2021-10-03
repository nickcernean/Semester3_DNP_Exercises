using System;
namespace Exercise_11
{
    class Program
    {
        public Program()
        {
          
        }
        public int CountClumps(int[] ArrayClump)
        {
            int ArrayLength = ArrayClump.Length;
            int Clumps = 0;
            for (int i = 0; i < ArrayLength - 1; i++)
            {
                int flag = 0;
                while (i < ArrayLength - 1 && ArrayClump[i] == ArrayClump[i + 1])
                {
                    flag = 1;
                    i++;
                }
                if (flag == 1)
                    Clumps++;
            }
            return Clumps;
        }
    }

}