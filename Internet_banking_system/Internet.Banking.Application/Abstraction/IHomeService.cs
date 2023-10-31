using Internet.Banking.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Application.Abstraction
{
    public interface IHomeService
    {
        CarouselCustomerViewModel GetIndexViewModel();
    }
}
