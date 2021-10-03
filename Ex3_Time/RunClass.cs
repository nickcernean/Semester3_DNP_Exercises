using System;
namespace Ex3_Time
{
    public class RunClass
    {
        static void Main(string[] args)
        {
            Time t = new Time(23, 55);
            Console.WriteLine(t);
            t.AddMinutes(10);
            Console.WriteLine(t);
            t.SubtractMinutes(30);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(20);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.AddMinutes(20);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(120);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(1560);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.AddMinutes(1560);
            Console.WriteLine(t);
            
                
                            }
    }
}