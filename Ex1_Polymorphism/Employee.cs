using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
    public abstract class Employee
    {
        public string Name;
        public Employee(string Name)
        { this.Name = Name; }
        public abstract double GetMonthlySalary();
    }
}