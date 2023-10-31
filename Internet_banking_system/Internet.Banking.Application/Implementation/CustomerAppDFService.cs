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
	}
}
