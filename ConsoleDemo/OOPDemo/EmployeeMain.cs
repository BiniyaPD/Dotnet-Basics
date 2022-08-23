using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.OOPDemo
{
    public class EmployeeMain
    {
        public void Main()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Sam"
            };
            Address address1 = new Address()
            {
                city = "Bangalore",
                state="Karnataka"
            };
            Address address2 = new Address()
            {
                city = "pune",
                state = "Karnataka"
            };

            //Add address to employee
            employee.AddAddress(address1);
            employee.AddAddress(address2);
            DisplayEmployeeData(employee);
            
        }

        private void DisplayEmployeeData(Employee employee)
        {
            Console.WriteLine($"Employee Id:{employee.EmployeeId} \t" +
                $"Employee Name:{employee.EmployeeName}");
            Console.WriteLine("Address Info");
            foreach(var address in employee.GetAddresses())
            {
                Console.WriteLine($"City:{address.city}\t" +
                $"State:{address.state}");
            }
            //Console.WriteLine($"City:{employee.address.city}\t" +
            //    $"State:{employee.address.state}");
        }
    }
}
