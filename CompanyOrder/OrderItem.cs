using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyOrder
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }

        public double GetAmount()
        {
            return Product.Price * Qty;
        }
    }
}
