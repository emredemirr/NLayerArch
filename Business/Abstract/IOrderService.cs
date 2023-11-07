using Entities.Concrete;

namespace Business.Abstract;

public interface IOrderService
{
    List<Order> GetAll();
    void Add(Order order);
    void Delete(Order order);
    void Update(Order order);
}