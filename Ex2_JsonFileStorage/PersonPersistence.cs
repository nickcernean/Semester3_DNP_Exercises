using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace Ex2_JsonFileStorage
{
    public class PersonPersistence
    {
        public PersonPersistence()
        {
        
        }

        public void StoreObjects(List<Person> persons)
        {
            string ObjAsJson = JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true });
            using StreamWriter sw = new StreamWriter("Person.txt");
            sw.WriteLine(ObjAsJson);

        }


    }
}