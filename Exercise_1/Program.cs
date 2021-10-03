using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        private String Name;
        
        public Program(string Name)
        {
            this.Name = Name;
        }
        public void ReturningName()
        {
            Console.WriteLine(GetName());
        }
        private string GetName()
        {
            return Name;
        }
    }
}