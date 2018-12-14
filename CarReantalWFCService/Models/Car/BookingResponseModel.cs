using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarReantalWFCService.Models.Car
{
	[DataContract]
	 public class BookingResponseModel
	{
		public BookingResponseModel()
		{
			TimeStamp = DateTime.UtcNow;
			CustumerBookings = new HashSet<BookingModel>();
		}
		[DataMember]
		public string BookingID { get; set; }
		[DataMember]
		public int CarID { get; set; }
		[DataMember]
		public int CustomerID { get; set; }
		[DataMember]
		public double TolTaltPrice { get; set; }
		[DataMember]
		public ICollection<BookingModel> CustumerBookings { get; set; }
		[DataMember]
		public DateTime TimeStamp { get; set; }




	}
}
