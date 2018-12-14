using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ICarService<T> where T : Car
    {
        List<T> GetBookable(DateTime from, DateTime to);
        void ReturnCar(int id);
        void LendCar(int id);
		T CreateCar(T car);
		void DeleteCar(int Id);
		T GetCar(string id);
		T UpdateCar(T car);

	}
}
