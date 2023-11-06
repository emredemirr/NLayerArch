using Entities.Concrete;

namespace Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetAllByCategory(int categoryId);
    void Add(Product product);
    void Delete(Product product);
    void Update(Product product);
}