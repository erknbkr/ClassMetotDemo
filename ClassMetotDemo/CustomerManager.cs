using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " customer added!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " customer deleted!");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Name\t: " + customer.Name 
                + "\nSurname\t: " + customer.Surname 
                + "\nSalary\t: " + customer.Salary.ToString()
                + "\ncustomer listed!");
        }
    }
}
