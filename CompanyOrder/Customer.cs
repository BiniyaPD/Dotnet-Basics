using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyOrder
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public Company Company { get; set; }
        private List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }
        public IEnumerable<Order> GetOrders()
        {
            return this.orders;
        }
        public virtual double GetCustomerTotalOrders()
        {
            double total = 0;
            foreach (var order in this.orders)
            {
                total += order.GetOrderTotal();
            }
            return total;
        }
    }
}
