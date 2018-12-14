using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarReantalWFCService.Models.Car
{
	[DataContract]
	public class BookingModel
	{
		[DataMember]
		public string CarID { get; set; }
		[DataMember]
		public string BookingID { get; set; }
		[DataMember]
		public DateTime StartTime { get; set; }
		[DataMember]
		public DateTime EndTime { get; set; }
		[DataMember]
		public int CustomerID { get; set; }

	}
}
