using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
    class FullTimeEmployee :Employee 
    {
        public double MonthlySalary;
 
        public FullTimeEmployee(string Name, double MonthlySalary) : base(Name) {
            this.MonthlySalary = MonthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
        
    }
}