using Internet.Banking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Infrastructure.Database
{
	public class DatabaseFake
	{
		public static IList<Customer> Customers { get; set; }

		static DatabaseFake()
		{
			Customers = new List<Customer>();
			Customers.Add(new Customer
			{
				Id = 1,
				CustomerName = "Michal",
				CustomerSurname = "Ryba",
				CustomerPhone = "387934938",
				CustomerEmail = "mr@centrum.cz",
				CustomerAdress = "Palackého 23"
			});
			Customers.Add(new Customer
			{
				Id = 2,
				CustomerName = "Denisa",
				CustomerSurname = "Kalandrová",
				CustomerPhone = "574584551",
				CustomerEmail = "dk@seznam.cz",
				CustomerAdress = "Štefáníkova 433"
			});
			Customers.Add(new Customer
			{
				Id = 3,
				CustomerName = "Adam",
				CustomerSurname = "Hamšík",
				CustomerPhone = "605488428",
				CustomerEmail = "ah@icloud.com",
				CustomerAdress = "Petříkova 58"
			});
		}
	}
}
