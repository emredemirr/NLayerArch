using Entities.Concrete;

namespace Business.Abstract;

public interface IProductService
{
    void Add(Product product);
    void Delete(Product product);
    void Update(Product product);
    List<Product> GetAll();
    List<Product> GetAllByCategory(int id);
    List<Product> GetByUnitPrice(decimal min, decimal max);
}