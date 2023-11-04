using Internet.Banking.Domain.Entities;
using Internet.Banking.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Application.Abstraction
{
	public interface ICustomerAppService
	{
		IList<Customer> Select();
		void Create(Customer customer);
		bool Delete(int id);	
		Customer Update(int id);
		void Update(Customer customer);
		
	}
	
}
