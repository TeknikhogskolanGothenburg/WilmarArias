using Domain;
using Repository;
using Services.IServices;
using System;
using System.Data.Entity;

namespace Services.Services
{
    public class CustomerService :  ICustomerService<Customer>
    {
		private readonly IRepository<Customer> repository;
        public CustomerService(DbContext context) 
        {
			repository = new Repository<Customer>(context);
        }

		public Customer CreateCustumer(Customer custumer)
		{
			{
				if (custumer == null)
					throw new Exception("The Custumer Is null");

				return repository.Insert(custumer);

			}
		}

		public Customer UpdateCustumer(Customer custumer)
		{
			return repository.Update(custumer);
		}
	}
}
