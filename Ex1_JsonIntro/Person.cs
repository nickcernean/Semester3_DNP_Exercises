using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_JsonIntro
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public char Sex { get; set; }
        public string[] Hobbies { get; set; }
        public Person(string FirstName, string LastName, int Age, double Height, bool IsMarried, char Sex, string[] Hobbies)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Height = Height;
            this.IsMarried = IsMarried;
            this.Sex = Sex;
            this.Hobbies = Hobbies;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Height: {Height},Ismarried: {IsMarried}, Sex:{Sex}, Hobbies:{Hobbies}";
        }

    }
}