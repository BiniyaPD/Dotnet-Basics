using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyOrder
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        private List<Product> products = new List<Product>();
        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Method to add customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }
        /// <summary>
        /// Method to return all Customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetCustomers()
        {
            return this.customers;
        }
        /// <summary>
        /// Method to add Product
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            this.products.Add(product);

        }
        /// <summary>
        /// Method to return all products
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetProducts()
        {
            return this.products;
        }
    }
}
