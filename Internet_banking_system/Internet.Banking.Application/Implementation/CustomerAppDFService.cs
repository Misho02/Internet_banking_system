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
    }
}
