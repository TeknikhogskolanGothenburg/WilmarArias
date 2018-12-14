using CarReantalWFCService.Models.Car;
using ContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UnitsOfWork.UnitofWorkPattern;
using AutoMapper;
using Domain;
using Services.IServices;
using CarReantalWFCService.ExeptioHandlers;
using CarReantalWFCService.Models.Custumer;

namespace CarReantalWFCService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalService" in both code and config file together.
    public class CarRentalService : ICarRentalService
    {
		private readonly IUnitOfWork unitOfWork;
		private readonly ICarService<Car> carService;
		
		public CarRentalService()
        {
			unitOfWork = new UnitOfWork(new DatabaseContext());
			 carService = unitOfWork.CarService;
		}
		#region Booking
		public BookingResponseModel CreateBooking(BookingModel booking)
		{
			try
			{

				var createdBooking = unitOfWork.BookingService.CreateBooking(Mapper.Map<Booking>(booking));
				unitOfWork.Save();
				var responseModel = Mapper.Map<BookingResponseModel>(createdBooking);
				responseModel.CustumerBookings = Mapper.Map<List<BookingModel>>(createdBooking.Customer.Bookings);
				return responseModel;
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
				new ServiceExeption()
				{

					Message = ExeptionResource.BookingErrorMessage,
					ErrorCode = ExeptionResource.BookingErrorCode
				});
			}
		}
		#endregion
		#region Customer
		public CustumerModel UpdateCustomer(CustumerModel custumer)
		{
			try
			{
				var updatedCustumer = unitOfWork.CustomerService.UpdateCustumer(Mapper.Map<Customer>(custumer));
				return Mapper.Map<CustumerModel>(updatedCustumer);
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
						new ServiceExeption
						{

							Message = string.Format(ExeptionResource.UpdatatedMessage, custumer?.ID),
							ErrorCode = ExeptionResource.UpdatatedMessage
						});
			}

		}
		public CustumerModel AddCustumer(CustumerModel custumer)
		{
			try
			{
				var createdCustumer = unitOfWork.CustomerService.CreateCustumer(Mapper.Map<Customer>(custumer));
				unitOfWork.Save();
				return Mapper.Map<CustumerModel>(createdCustumer);
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
					new ServiceExeption
					{

						Message = ExeptionResource.CreateErrorMessage,
						ErrorCode = ExeptionResource.CreateErrorMessage
					});
			}

		}
		#endregion
		#region Car
		public void AddCar(CarModel car)
		{
			try
			{
				carService.CreateCar(Mapper.Map<Car>(car));
				unitOfWork.Save();
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
					new ServiceExeption {
						
						Message = ExeptionResource.CreateErrorMessage,
						ErrorCode = ExeptionResource.CreateErrorMessage
					});
			}
		}

		

		public void DeleteCar(int id)
		{
			try
			{
				carService.DeleteCar(id);
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
					new ServiceExeption()
					{

						Message = string.Format(ExeptionResource.ResourceDontFoundMessage,id),
						ErrorCode = ExeptionResource.ResourceDontFoundErrorCode
					});
			}

			
		}

		public CarModel GetCar(string id)
		{
			try
			{

				return Mapper.Map<CarModel>(carService.GetCar(id));
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
					new ServiceExeption
					{

						Message = string.Format(ExeptionResource.ResourceDontFoundMessage, id),
						ErrorCode = ExeptionResource.ResourceDontFoundErrorCode
					});
			}
		}

		public CarModel UpdateCar(CarModel car)
		{
			try
			{
				var updatedCar = carService.UpdateCar(Mapper.Map<Car>(car));
				return Mapper.Map<CarModel>(updatedCar);
			}
			catch
			{
				throw new FaultException<ServiceExeption>(
						new ServiceExeption
						{

							Message = string.Format(ExeptionResource.UpdatatedMessage, car.ID),
							ErrorCode = ExeptionResource.UpdatatedMessage
						});
			}
		}
		#endregion
	}
}
