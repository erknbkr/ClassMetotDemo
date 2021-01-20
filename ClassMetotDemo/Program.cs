using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.Name = "Erkan";
            customer1.Surname = "BUKER";
            customer1.Salary = 1000;

            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.List(customer1);
        }
    }
}
