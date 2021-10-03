using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json;
namespace Ex2_JsonFileStorage
{
    class RunClass
    {

        static void Main(string[] args)
        {
            PersonPersistence PersonPersistence = new();
            List<Person> People = new List<Person>();
            string[] Hobbies = { "Cycling", "Jogging", "Hiking" };
            People.Add(new Person("Nicolae", "Cernean", 21, 1.80, false, 'M', Hobbies));
            People.Add(new Person("Andrei", "Tulumb", 20, 1.85, true, 'M', Hobbies));
            People.Add(new Person("Mihaela", "Guvir", 19, 1.60, true, 'F', Hobbies));

            string ObjAsJson = JsonSerializer.Serialize(People, new JsonSerializerOptions { WriteIndented = true });

            List<Person> peoples = JsonSerializer.Deserialize<List<Person>>(ObjAsJson);
            PersonPersistence.StoreObjects(People);

            //People.foreach (i => console.writeLine("{0}\n", i.tostring())) ;
            Console.WriteLine(ObjAsJson);







        }
    }
}