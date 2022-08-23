using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyOrder
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        private List<OrderItem> orderItems = new List<OrderItem>();
        /// <summary>
        /// Method to add orderitem
        /// </summary>
        /// <param name="product"></param>
        public void AddOrderItem(OrderItem orderItem)
        {
            this.orderItems.Add(orderItem);
        }
        /// <summary>
        /// method to return all product
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderItem>GetOrderItems()
        {
            return this.orderItems;
        }
        public double GetOrderTotal()
        {
            double total = 0;
            foreach (var orderItem in this.orderItems)
            {
                total += orderItem.GetAmount();
            }
            return total;
        }
    }
}
