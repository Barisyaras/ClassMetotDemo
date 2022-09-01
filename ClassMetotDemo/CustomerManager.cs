using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void AddCustomer(string name, string surname)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Surname = surname;
            customer.Id = GetLastCustomerId() + 1;
            customerList.Add(customer);
        }

        public void ShowCustomers()
        {
            foreach (var item in customerList)
            {
                var customerInfo = $" {item.Id} {item.Name} {item.Surname}";
                Console.WriteLine("Customers : " + customerInfo);
                Console.WriteLine("Total number of customers is " + (customerList.Count));
                Console.WriteLine("");
            }
        }

        public bool DeleteCustomer(int Id)
        {
            int itemIndex = -1;
            foreach (var item in customerList)
            {
                if (item.Id == Id)
                {
                    itemIndex = customerList.IndexOf(item);
                    break;
                }
            }

            if (itemIndex >= 0)
            {
                customerList.RemoveAt(itemIndex);
                return true;
            }
            return false;
        }

        private int GetLastCustomerId()
        {
            int lastId = 0;

            if (customerList != null && customerList.Any())
            {
                foreach (var item in customerList)
                {
                    if (lastId < item.Id)
                        lastId = item.Id;
                }
            }

            return lastId;
        }
    }
}