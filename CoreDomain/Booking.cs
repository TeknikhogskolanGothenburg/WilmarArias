using BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Booking:BaseEntity
    {
		[UpdatableField]
		public int CarID { get; set; }
        public int CustomerID { get; set; }
		public double TolTaltPrice { get; set; }
		[UpdatableField]
		public DateTime StartTime { get; set; }
		[UpdatableField]
		public DateTime EndTime { get; set; }
		[UpdatableField]
		public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
