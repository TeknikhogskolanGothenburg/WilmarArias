using CarReantalWFCService.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using CarReantalWFCService.ExeptioHandlers;
using CarReantalWFCService.Models.Custumer;

namespace CarReantalWFCService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.
    [ServiceContract]
    public interface ICarRentalService
    {
		[OperationContract]
		[FaultContract(typeof(ServiceExeption))]
		[WebInvoke(UriTemplate = "/AddCar", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		void AddCar(CarModel car);
		[FaultContract(typeof(ServiceExeption))]
		[OperationContract]
		[WebInvoke(UriTemplate = "/DeleteCar", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		void DeleteCar(int id);
		[FaultContract(typeof(ServiceExeption))]
		[OperationContract]
		[WebInvoke(UriTemplate = "/UpdateCar", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		CarModel UpdateCar(CarModel car);
		[OperationContract]
		[WebGet(UriTemplate = "/GetCar/{id}" ,ResponseFormat = WebMessageFormat.Json)]
		CarModel GetCar(string id);
		[OperationContract]
		[WebInvoke(UriTemplate = "/CreateBooking", Method = "POST",RequestFormat =WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		BookingResponseModel CreateBooking(BookingModel booking);
		[OperationContract]
		[WebInvoke(UriTemplate = "/UpdateCustomer", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		CustumerModel UpdateCustomer(CustumerModel custumer);
	}
}
