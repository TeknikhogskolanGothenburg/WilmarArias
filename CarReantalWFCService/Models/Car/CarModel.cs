using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarReantalWFCService.Models.Car
{
	[DataContract]
	public class CarModel
	{
		[DataMember]
		public int ID { get; set; }
		[DataMember]
		public string RegistrationNumber { get; set; }
		[DataMember]
		public string Brand { get; set; }
		[DataMember]
		public string Model { get; set; }
		[DataMember]
		public int? Year { get; set; }
		[DataMember]
		public bool Avaliable { get; set; }
		[DataMember]
		public DateTime test { get { return DateTime.Now; } set { this.test = DateTime.Now ; }}

	}
}
