using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class Employee
    {
        //private int employeeId;
        //private string employeeName;
        public string employeeName { get; set; }
        public int employeeId { get; set; }
        //public void SetEmployeeId(int employeeId)
        //{
        //    this.employeeId = employeeId;
        //}
        //public int GetEmployeeId()
        //{
        //    return this.employeeId;
        //}
        //public void SetEmployeeName(string employeeName)
        //{
        //    this.employeeName = employeeName;
        //}
        //public string GetEmployeeName()
        //{
        //    return this.employeeName;
        //}
    }
    class PropDemo
    {
        public void Main()
        {
            Employee employee = new Employee();
            //employee.SetEmployeeId(1002);
            //employee.SetEmployeeName("Biniya");
            //Console.WriteLine($"Employee Id:{employee.GetEmployeeId()}"+
            //                 $"\tEmployee Name:{employee.GetEmployeeName()}");

            employee.employeeName = "Biniya";
            employee.employeeId = 1001;
            Console.WriteLine($"Employee Id:{employee.employeeId}" +
                          $"\tEmployee Name:{employee.employeeName}");


        }
    }
}
