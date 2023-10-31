using Internet.Banking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Infrastructure.Database
{
    internal class DatabaseInit
    {
        public IList<Customer> GetCustomers()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                Id = 1,
                CustomerName = "Michal",
                CustomerSurname = "Ryba",
                CustomerPhone = "387934938",
                CustomerEmail = "mr@centrum.cz",
                CustomerAdress = "Palackého 23"
            });
            customers.Add(new Customer
            {
                Id = 2,
                CustomerName = "Denisa",
                CustomerSurname = "Kalandrová",
                CustomerPhone = "574584551",
                CustomerEmail = "dk@seznam.cz",
                CustomerAdress = "Štefáníkova 433"
            });
            customers.Add(new Customer
            {
                Id = 3,
                CustomerName = "Adam",
                CustomerSurname = "Hamšík",
                CustomerPhone = "605488428",
                CustomerEmail = "ah@icloud.com",
                CustomerAdress = "Petříkova 58"
            });
            return customers;
        }
        public IList<Carousel> GetCarousels()
        {
            IList<Carousel> carousels = new List<Carousel>();

            carousels.Add(new Carousel()
            {
                Id = 1,
                ImageSrc = "/img/carousels/Carousel_connection.jpg",
                ImageAlt = "First slide"
            });

            carousels.Add(new Carousel()
            {
                Id = 2,
                ImageSrc = "/img/carousels/Carousel_identity.jpg",
                ImageAlt = "Second slide"
            });

            carousels.Add(new Carousel()
            {
                Id = 3,
                ImageSrc = "/img/carousels/Carousel_online_banking.jpg",
                ImageAlt = "Third slide"
            });

            return carousels;
        }
    }
}
