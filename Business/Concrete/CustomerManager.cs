using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAllByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer customer)
    {
        throw new NotImplementedException();
    }
}