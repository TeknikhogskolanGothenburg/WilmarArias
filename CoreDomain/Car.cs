using BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class Car : BaseEntity
    {
		[UpdatableField]
        public string RegistrationNumber { get; set; }
		[UpdatableField]
		public string Brand { get; set; }
		[UpdatableField]
		public string Model { get; set; }
		[UpdatableField]
		public int? Year { get; set; }
		
		public bool Avaliable { get; set; }

		[UpdatableField]
		public double MinutePrice { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
