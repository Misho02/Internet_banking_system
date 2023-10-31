using Internet.Banking.Domain.Entities;
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
	}
}
