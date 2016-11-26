using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPO
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            List<Customer> customerList = new List<Customer>();
            Customer customer = new Customer();
            Address address = new Address();
            Order order = new Order();
            customer.FirstName = "Gouse";
            customer.LastName = "Makandar";
            customer.EmailID = "gouse@jamsons.in";

            address.StreetOne = "3rd Cross";
            address.StreetTwo = "Pemme Gowda Road";
            address.City = "Bangalore";
            address.PinCode = "560032";

            customer.HomeAddress = address;
            order.ShippingAddress = address;

            if (customer.Validate()) 
            {
                if (customer.Save())
                {
                    customerList.Add(customer);
                }
                
            }
            Customer temp = customer.Retrieve(id);
            if (temp != null)
            {
                customerList.Add(temp);
            }
            if (customerList.Contains(customer))
            {
                Display(customer);
            }
            else
            {
                Console.WriteLine("No records found!");
            }
            
            Product product = new Product();
            product.ProductName = "iPhone 6S plus";
            product.Description = "64 GB";
            product.CurrentPrice = 60000f;
            product.Retrieve(product);
            if (product.Save())
            {
                DisplayProduct(product);
            }

            order.OrderDate = DateTime.Now;
            order.Retrieve(order);
            if (order.Save())
            {
                DisplayOrder(customer, order, address);
            }
            Console.ReadLine();
        }

        private static void DisplayOrder(Customer customer, Order order, Address address)
        {
            Console.WriteLine("Order Details");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Order id: \t\t" + order.Id);
            Console.WriteLine("Order date: \t\t" + order.OrderDate);
            Console.WriteLine("Order Shipping address: " + order.ShippingAddress.City);
            Console.WriteLine("Customer id: \t\t" + customer.Id);
            Console.WriteLine("Customer first name: \t" + customer.FirstName);
            Console.WriteLine("Customer last name: \t" + customer.LastName);
            Console.WriteLine("Customer email: \t" + customer.EmailID);
            Console.WriteLine("-------------------------------------------");
        }

        private static void DisplayProduct(Product product)
        {
            Console.WriteLine("Product Details");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Product id: \t\t" + product.Id);
            Console.WriteLine("Product name: \t\t" + product.ProductName);
            Console.WriteLine("Product description: \t" + product.Description);
            Console.WriteLine("Product current price: \t" + product.CurrentPrice);
            Console.WriteLine("");
        }

        private static void Display(Customer customer)
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Customer id: \t\t" + customer.Id);
            Console.WriteLine("Customer first name: \t" + customer.FirstName);
            Console.WriteLine("Customer last name: \t" + customer.LastName);
            Console.WriteLine("Customer email: \t" + customer.EmailID);
            Console.WriteLine("Customer home address: \t" + customer.HomeAddress.City);
            Console.WriteLine("");
        }
    }
}
