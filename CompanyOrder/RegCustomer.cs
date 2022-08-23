using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyOrder
{
    public class RegCustomer:Customer
    {
        public int Discount { get; }

        public RegCustomer(int discount)
        {
            this.Discount = discount;
        }

        public override double GetCustomerTotalOrders()
        {
            double total = 0;
            var orderValue = base.GetCustomerTotalOrders();
            var discount = orderValue * this.Discount / 100;
            total = orderValue - discount;
            return total;
        }
    }
}
