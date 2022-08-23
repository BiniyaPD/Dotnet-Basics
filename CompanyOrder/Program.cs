using System;

namespace CompanyOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create products
            Product product1 = new Product() { Pid = 101, ProductName = "iphone 4S" ,Price=25000};
            Product product2 = new Product() { Pid = 102, ProductName = "iphone 5S",Price = 35000 };
            Product product3 = new Product() { Pid = 103, ProductName = "iphone 6S",Price = 45000 };
            Product product4 = new Product() { Pid = 104, ProductName = "iphone 7S",Price = 50000 };
            Product product5 = new Product() { Pid = 105, ProductName = "iphone 8S",Price = 55000 };
            Product product6 = new Product() { Pid = 106, ProductName = "iphone 9S",Price = 65000 };
            Product product7 = new Product() { Pid = 107, ProductName = "iphone Mini",Price = 70000 };
            Product product8 = new Product() { Pid = 108, ProductName = "iphone 11s",Price = 80000 };

            //2.Create company
            Company company = new Company() { CompanyId = 1001, CompanyName = "Apple" };

            //3.Add product to the company
            company.AddProduct(product1);
            company.AddProduct(product2);
            company.AddProduct(product3);
            company.AddProduct(product4);
            company.AddProduct(product5);
            company.AddProduct(product6);
            company.AddProduct(product7);
            company.AddProduct(product8);

            //4.Create Customer
            Customer customer1 = new Customer() { CustomerId = 10, CustomerName = "Ajay", MobileNo = "8976543212" };
            Customer customer2 = new Customer() { CustomerId = 11, CustomerName = "Rahul", MobileNo = "9976543772" };
            //Customer customer3 = new Customer() { CustomerId = 12, CustomerName = "Amala", MobileNo = "9976588212" };
            Customer customer3 = new RegCustomer(10) { CustomerId = 12, CustomerName = "Amala", MobileNo = "9971233772" };

            //5.Add Customers to Comapny
            company.AddCustomer(customer1);
            company.AddCustomer(customer2);
            company.AddCustomer(customer3);

            //6.Add Comapny to the Customer
            customer1.Company=company;
            customer2.Company = company;
            customer3.Company = company;

            //7.Create Order
            Order order1 = new Order() { OrderId = 7001, OrderDate = DateTime.UtcNow };
            Order order2 = new Order() { OrderId = 7002, OrderDate = DateTime.UtcNow };
            Order order3 = new Order() { OrderId = 7003, OrderDate = DateTime.UtcNow };
            Order order4 = new Order() { OrderId = 7004, OrderDate = DateTime.UtcNow };
            Order order5 = new Order() { OrderId = 7005, OrderDate = DateTime.UtcNow };
            Order order6 = new Order() { OrderId = 7006, OrderDate = DateTime.UtcNow };

            //8.Add Order to Customer
            order1.Customer = customer1;
            order2.Customer = customer3;
            order3.Customer = customer2;
            order4.Customer = customer1;
            order5.Customer = customer3;
            order6.Customer = customer2;

            //9.Add Customers to Order
            customer1.AddOrder(order1);
            customer1.AddOrder(order4);
            customer2.AddOrder(order3);
            customer2.AddOrder(order2);
            customer3.AddOrder(order5);
            customer3.AddOrder(order1);

            //10.Create Order Item
            OrderItem orderItem1 = new OrderItem() { Qty = 1 };
            OrderItem orderItem2 = new OrderItem() { Qty = 3 };
            OrderItem orderItem3 = new OrderItem() { Qty = 2 };
            OrderItem orderItem4 = new OrderItem() { Qty = 4 };
            OrderItem orderItem5 = new OrderItem() { Qty = 3 };
            OrderItem orderItem6 = new OrderItem() { Qty = 1 };
            OrderItem orderItem7 = new OrderItem() { Qty = 2 };
            OrderItem orderItem8 = new OrderItem() { Qty = 2 };
            OrderItem orderItem9 = new OrderItem() { Qty = 5 };
            OrderItem orderItem10 = new OrderItem() { Qty = 1 };
            OrderItem orderItem11 = new OrderItem() { Qty = 3 };
            OrderItem orderItem12 = new OrderItem() { Qty = 1 };


            //11.Add Products to OrderItem
            orderItem1.Product=product1;
            orderItem2.Product=product2;
            orderItem3.Product=product3;
            orderItem4.Product=product4;
            orderItem5.Product=product5;
            orderItem6.Product=product6;
            orderItem7.Product=product7;
            orderItem8.Product=product8;
            orderItem9.Product = product7;
            orderItem10.Product=product4;
            orderItem11.Product=product5;
            orderItem12.Product=product3;

            //12 Add order items to order
            order1.AddOrderItem(orderItem1);
            order2.AddOrderItem(orderItem2);
            order3.AddOrderItem(orderItem3);
            order4.AddOrderItem(orderItem4);
            order5.AddOrderItem(orderItem5);
            order6.AddOrderItem(orderItem6);
            order1.AddOrderItem(orderItem7);
            order2.AddOrderItem(orderItem8);
            order3.AddOrderItem(orderItem9);
            order4.AddOrderItem(orderItem10);
            order5.AddOrderItem(orderItem11);
            order6.AddOrderItem(orderItem12);

            //12.Display Company Data
            DisplayCompanyInfo(company);
               

        }

        private static void DisplayCompanyInfo(Company company)
        {
            Console.WriteLine("Company Data");
            DrawLine(20, "-");
            Console.WriteLine($"Company ID: {company.CompanyId} \t Company Name: {company.CompanyName}");
            DrawLine(50, "-");
            foreach (var customer in company.GetCustomers())
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId} \t Customer Name: {customer.CustomerName}");
                Console.WriteLine($"Total customer Order Value: \t\t {customer.GetCustomerTotalOrders()}");
                DrawLine(60, "-");
                foreach (var order in customer.GetOrders())
                {
                    Console.WriteLine($"Order ID: {order.OrderId} \t Order Date: {order.OrderDate}");
                    DrawLine(60, "-");
                    Console.WriteLine("PId \t Name \t\t Price \t Qty \t Amount");
                    DrawLine(60, "-");
                    foreach (var orderItem in order.GetOrderItems())
                    {
                        Console.WriteLine($"{orderItem.Product.Pid} \t {orderItem.Product.ProductName}" +
                            $" \t {orderItem.Product.Price} \t {orderItem.Qty} \t" +
                            $"{orderItem.GetAmount()}");
                    }
                    DrawLine(60, "-");
                    Console.WriteLine($"Total: \t\t\t\t\t {order.GetOrderTotal()}");
                    DrawLine(60, "-");
                }
                DrawLine(60, "*");
            }

        }
        private static void DrawLine(int noOfPrint, string pattern)
        {
            for (int i = 0; i < noOfPrint; i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine();
        }
    }
}
