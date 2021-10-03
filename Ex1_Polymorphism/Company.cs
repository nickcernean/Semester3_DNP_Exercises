using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Polymorphism
{
    class Company
    {

        public List<Employee> employees; 
        public Company()
        {
            employees = new List<Employee>();
        }
        public  double GetMonthlySalaryTotal()
        {
            double sum = 0;
            foreach (var i in employees)
            {
                sum += i.GetMonthlySalary();
            }
            return sum;
        }
        public void HireNewEmployee(Employee employee)
        {
            employees.Add(employee);

        }
    }
}