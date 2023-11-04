using Internet.Banking.Application.Abstraction;
using Internet.Banking.Domain.Entities;
using Internet.Banking.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Application.Implementation
{
	public class CustomerAppDFService: ICustomerAppService
	{
		public IList<Customer> Select()
		{
			return DatabaseFake.Customers;
		}
        public void Create(Customer customer)
        {
            if (DatabaseFake.Customers != null && DatabaseFake.Customers.Count > 0)
            {
                customer.Id = DatabaseFake.Customers.Last().Id + 1;
            }
            else
                customer.Id = 1;
            if (DatabaseFake.Customers != null)
            {
                DatabaseFake.Customers.Add(customer);
            }
        }
        public bool Delete(int id)
        {
            bool deleted = false;
            Customer? customer = DatabaseFake.Customers.FirstOrDefault(cust => cust.Id == id);
            if (customer != null)
            {
                deleted = DatabaseFake.Customers.Remove(customer);
            }
            return deleted;
        }
        public Customer Update(int id)
        {
            Customer? customer_db = DatabaseFake.Customers.FirstOrDefault(cust => cust.Id == id);
            return customer_db;
        }
        public void Update(Customer customer)
        {
            Customer? customer_db = Update(customer.Id);
            
            if (customer_db != null)
            {
                customer_db.CustomerName = customer.CustomerName;
                customer_db.CustomerSurname = customer.CustomerSurname;
                customer_db.CustomerPhone = customer.CustomerPhone;
                customer_db.CustomerEmail = customer.CustomerEmail;
                customer_db.CustomerAdress = customer.CustomerAdress;
            }
        }
    }
}
