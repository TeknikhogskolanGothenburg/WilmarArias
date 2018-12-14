
using Domain;
using Services;
using Services.IServices;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitsOfWork.UnitofWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DbContext _context;

        public ICarService<Car> CarService { get; set; }
        public IBookingService BookingService { get; set; }
        public ICustomerService<Customer> CustomerService { get; set; }

        public UnitOfWork(DbContext context)
        {
            this._context = context;
            CarService = new CarService(context);
            BookingService = new BookingService(context,CarService);
            CustomerService = new CustomerService(context);
            
        }

       

        public void Dispose()
        {
            _context.Dispose();
            CarService = null;
            BookingService = null;
            CustomerService = null;
           
            
        }

        public int Save()
        {
           return _context.SaveChanges();
           
        }

       
    }
}
