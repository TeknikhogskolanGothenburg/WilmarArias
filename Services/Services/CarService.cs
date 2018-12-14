using Domain;
using Repository;
using Services.IServices;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Services
{
    public class CarService : ICarService<Car>
    {
		private readonly IRepository<Car> repository;

        public CarService(DbContext context) 
        {
			repository = new Repository<Car>(context);
        }
        /// <summary>
        /// Finds all unbooked cars within a time span
        /// </summary>
        /// <param name="from"> the start of the time span</param>
        /// <param name="to">the end of the time span</param>
        /// <returns></returns>
        public List<Car> GetBookable(DateTime from, DateTime to)
        {
            List<Car> cars = repository.GetAll().ToList();
            List<Car> unbookedCars = cars.Where(c =>
            c.Bookings == null ||
            c.Bookings.Where(b => !(b.StartTime > to || b.EndTime < from)).ToList().Count == 0).ToList();
            return unbookedCars;
        }
	    public Car CreateCar(Car car)
		{
			if (car == null)
				throw new Exception("The Car Is null");

			return repository.Insert(car);

		}
        public void ReturnCar(int id)
        {

			repository.FindByID(id).Avaliable = true;
        }

        public void LendCar(int id)
        {
			
			repository.FindByID(id).Avaliable = false;
        }

		public void DeleteCar(int Id)
		{
			var car = repository.FindByID(Id);
			if (car == null)
				throw new Exception("car not found!");

			repository.Delete(car);
		}

		public Car GetCar(string id)
		{
			if (!int.TryParse(id, out var carId))
				throw new Exception("The ID needs to be a Int32 datatype");

			 return repository.FindByID(carId);
		}

		public Car UpdateCar(Car car)
		{
			return repository.Update(car);
		}
	}
}
