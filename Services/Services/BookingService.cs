
using Domain;
using Repository;
using Services.IServices;
using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

namespace Services.Services
{
    public class BookingService : Repository<Booking>, IBookingService
    {
        private readonly ICarService<Car> _carService;
        public BookingService(DbContext context, ICarService<Car> carService) : base(context)
        {
            _carService = carService;
        }

		private double CalculateBookingPrice(double minutePrice,DateTime startime, DateTime endTime)
		{
			var timeStamp = endTime.Subtract(startime);
			if (timeStamp.TotalMinutes < 60)
				throw new Exception("startdate have to be bigger than endtime!");
			var timespam = endTime.Subtract(startime);
			var totalprice = 0.0;
			for(int i = 0; i < timespam.TotalMinutes; i++ )
			{
				totalprice += minutePrice;
			}
			return totalprice;
		}


		public Booking CreateBooking(Booking booking)
        {
            var Currentcustumer = GetRepository(booking.Customer).FindByID(booking.CustomerID);
			var currentCar = GetRepository(booking.Car).FindByID(booking.CarID);
            var avaliableCars = _carService.GetBookable(booking.StartTime, booking.EndTime);

            bool noPreviousBooking = avaliableCars.Contains(currentCar);
			var timeStamp = booking.EndTime.Subtract(booking.StartTime);


			if (
                Currentcustumer != null && timeStamp.TotalMinutes > 60
                &&
                noPreviousBooking)
            {
                booking.Customer = Currentcustumer;
                booking.CustomerID = Currentcustumer.ID;
				booking.TolTaltPrice = CalculateBookingPrice(currentCar.MinutePrice, booking.StartTime, booking.EndTime);


                return Insert(booking);
            }
            throw new Exception("The input data does not match the constrains!");


        }

        public ICollection GetAllAvailableBookings()
        {

            return GetAllWhere(x => x.StartTime.Day >= DateTime.UtcNow.Day).ToList();


        }

    }
}
