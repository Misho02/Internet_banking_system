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
		public static IList<Carousel> Carousels { get; set; }

		static DatabaseFake()
		{
			
            DatabaseInit dbInit = new DatabaseInit();
            Customers = dbInit.GetCustomers();
            Carousels = dbInit.GetCarousels();
        }
	}
}
