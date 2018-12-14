using BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer:BaseEntity
    {
		[UpdatableField]
		public string FirstName { get; set; }
		[UpdatableField]
		public string LastName { get; set; }
		[UpdatableField]
		public string Email { get; set; }
		[UpdatableField]
		public int Tel { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}

