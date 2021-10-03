using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json;
namespace Ex1_JsonIntro
{
    class RunClass
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] Hobbies = { "Cycling", "Jogging", "Hiking" };
            people.Add(new Person("Nicolae", "Cernean", 21, 1.80, false, 'M', Hobbies));
            people.Add(new Person("Andrei", "Tulumb", 20, 1.85, true, 'M', Hobbies));
            people.Add(new Person("Mihaela", "Guvir", 19, 1.60, true, 'F', Hobbies));

            string ObjAsJson = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });

            List<Person> peoples = JsonSerializer.Deserialize<List<Person>>(ObjAsJson);

            
            //people.ForEach(i => Console.Write("{0}\n", i.ToString()));
            Console.WriteLine(ObjAsJson);

            //  Console.ReadLine();



        }
    }
}