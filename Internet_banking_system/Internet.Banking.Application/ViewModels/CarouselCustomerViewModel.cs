using Internet.Banking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Application.ViewModels
{
    public class CarouselCustomerViewModel
    {
        public IList<Carousel> Carousels { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}
