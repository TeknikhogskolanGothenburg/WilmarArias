using Domain;
using Repository;

namespace Services.IServices
{
    public interface ICustomerService<T> where T :Customer
    {
	 T CreateCustumer(T custumer);
		T UpdateCustumer(T custumer);


	}
}
