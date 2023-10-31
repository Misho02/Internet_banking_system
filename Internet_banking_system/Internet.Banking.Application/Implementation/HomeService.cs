using Internet.Banking.Application.Abstraction;
using Internet.Banking.Application.ViewModels;
using Internet.Banking.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Application.Implementation
{
    public class HomeService: IHomeService
    {
        public CarouselCustomerViewModel GetIndexViewModel()
        {
            CarouselCustomerViewModel viewModel = new CarouselCustomerViewModel();
            viewModel.Customers = DatabaseFake.Customers;
            viewModel.Carousels = DatabaseFake.Carousels;
            return viewModel;
        }
    }
}
