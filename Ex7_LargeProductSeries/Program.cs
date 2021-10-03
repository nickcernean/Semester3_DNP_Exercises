using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_LargeProductSeries
{
    class Program
    {
        public Program()
        {

        }

        public void LargestProductSeries(int Input)
        {
            while (Input > 0)
            {
                int Remainder = Input % 10000;
                Input/=10000;
                while(Remainder>0)
                {  //1234
                    int A= Remainder % 10;// 123 a==4
                    Remainder /= 10; //123
                    int B = Remainder % 10;// b==3
                    Remainder /= 10;//12
                    int C = Remainder % 10;//c==2
                    Remainder /= 10;//1
                    int D = Remainder % 10;//d==1
                    if (A * B * C * D == 5832)
                    {
                        Console.WriteLine($"{D}{C}{B}{A}"); 
                    }

                }
            }

            
        }




    }
}