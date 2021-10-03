using System;
namespace Exercise_3
{
    class RunClass
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Nick";
            person.Introduce();
            Console.ReadLine();
        }
    }
}