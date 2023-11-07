using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public List<Customer> GetAll()
    {
        return _customerDal.GetAll();
    }

    public void Add(Customer customer)
    {
        _customerDal.Add(customer);
    }

    public void Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer customer)
    {
        _customerDal.Update(customer);
    }
}