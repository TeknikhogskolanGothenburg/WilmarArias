using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CarReantalWFCService;
using AutoMapper;
using CarReantalWFCService.Models.Car;
using Domain;
using BaseClasses;
using CarReantalWFCService.Models.Custumer;

namespace CarRental.Host.App
{
    class Program
    {
        static void Main(string[] args)
        {
			AutomappCofig();

			ServiceHost Host = new ServiceHost(typeof(CarRentalService));
            Host.Open();

            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();
        }
		static void AutomappCofig()
		{
			AutoMapper.Mapper.Initialize(x => {
				x.CreateMap<CarModel, Car>();
				x.CreateMap< Car, CarModel>();
				x.CreateMap<BookingModel, Booking>()
				.ForMember(id => id.ID, cf => cf.MapFrom(z => z.BookingID));
				x.CreateMap<Booking, BookingModel>()
				.ForMember(id => id.BookingID, cf => cf.MapFrom(z => z.ID));
				x.CreateMap<BookingResponseModel, Booking>().ForMember(j => j.ID, k => k.MapFrom(l => l.BookingID));
				x.CreateMap<Booking, BookingResponseModel>().ForMember(j => j.BookingID, k => k.MapFrom(l => l.ID));
				x.CreateMap<CustumerModel, Customer>();
				x.CreateMap<Customer, CustumerModel>();
				//.ForMember(c => c.CustumerBookings, l => l.MapFrom(k => k.Customer.Bookings));
				//.ForPath(j => j.CustumerBookings, f => f.MapFrom(l => l.Customer.Bookings));

			});
		}
    }
}
