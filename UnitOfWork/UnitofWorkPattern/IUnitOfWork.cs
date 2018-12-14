using Domain;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfWork.UnitofWorkPattern
{
    public interface IUnitOfWork:IDisposable
    {
        int Save();
      
        //Repositories exemepl
        ICarService<Car> CarService { get; set; }
        IBookingService BookingService { get; set; }
        ICustomerService<Customer> CustomerService { get; set; }

    }
}
