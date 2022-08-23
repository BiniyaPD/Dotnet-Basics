using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Deligate
{
    delegate bool isPromotable(Employee employee);
    class Employee
    {
        public string EmployeeName { get; set; }
        public double Salary { get; set; }

    }

    class EmployeeUtil
    {
        public IEnumerable<Employee> GetEmployeesPromotionPromotion(List<Employee> employees, isPromotable promotable)
        {
            List<Employee> promotableEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (promotable(employee))
                {
                    promotableEmployees.Add(employee);
                }
            }
            return promotableEmployees;


        }

    }
    public class DeligateDemo3
    {
        public void Main()
        {
            List<Employee> employees = new List<Employee>()
           {
            new Employee()
            {
                EmployeeName="Sam",
                Salary=40000,
            },
            new Employee()
            {
                EmployeeName="Ram",
                Salary=80000,
            },
            new Employee()
            {
                EmployeeName="Akshay",
                Salary=20000,
            },
            new Employee()
            {
                EmployeeName="Arun",
                Salary=30000,
            },
            new Employee()
            {
                EmployeeName="Mahi",
                Salary=15000,
            },
          };
            EmployeeUtil util = new EmployeeUtil();
            isPromotable promotable = new isPromotable(PromotBySalary);
            var listEmployee=util.GetEmployeesPromotionPromotion(employees, promotable);
            Display(listEmployee);
        }

        private void Display(IEnumerable<Employee> listEmployee)
        {
            Console.WriteLine("Name \t Salary");
            Console.WriteLine("-------------------");
            foreach (var employee in listEmployee)
            {
                Console.WriteLine($"{employee.EmployeeName}\t{employee.Salary}");
            }
        }

        private bool PromotBySalary(Employee employee)
        {
            if(employee.Salary>50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }   
   
}
