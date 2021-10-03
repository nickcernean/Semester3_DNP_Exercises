using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
    class RunClass
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Employee employee1 = new FullTimeEmployee("Nick Cernean",152.2);
            Employee employee2 = new FullTimeEmployee("Jeff Bezos",132.5);
            Employee employee3 = new FullTimeEmployee("Elon Tusk",182.9);
            Employee employee4 = new FullTimeEmployee("Morty Smith",123.7);
            Employee employee5 = new PartTimeEmployee("Rick Sanchez",123.9,35);
            Employee employee6 = new PartTimeEmployee("Jerry Smith",190.7,70);
            Employee employee7 = new PartTimeEmployee("Bet Smith",163.8,50);
            Employee employee8 = new PartTimeEmployee("Matthew McConaghey", 154.3,40);

            company.HireNewEmployee(employee1);
            company.HireNewEmployee(employee2);
            company.HireNewEmployee(employee3);
            company.HireNewEmployee(employee4);
            company.HireNewEmployee(employee5);
            company.HireNewEmployee(employee6);
            company.HireNewEmployee(employee7);
            company.HireNewEmployee(employee8);

            Console.WriteLine(company.GetMonthlySalaryTotal());
        }
    }
}