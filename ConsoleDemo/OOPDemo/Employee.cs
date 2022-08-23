using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.OOPDemo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        //public Address address { get; set; }

        public List<Address> addresses = new List<Address>();

        public void AddAddress(Address address)
        {
            this.addresses.Add(address);
        }

        public IEnumerable<Address> GetAddresses()
        {
            return this.addresses;
        }
    }
}
