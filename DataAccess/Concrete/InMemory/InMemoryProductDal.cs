using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{
    private readonly List<Product> _products = new()
    {
        new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardık", UnitPrice = 15, UnitsInStock = 15},
        new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
        new Product{ProductId = 3, CategoryId = 2, ProductName = "Telefon",UnitPrice = 1500, UnitsInStock = 2},
        new Product{ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
        new Product{ProductId = 5, CategoryId = 2, ProductName = "Fare",   UnitPrice = 85, UnitsInStock = 1}
    };
    
    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product product)
    {
        var productDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId) ?? throw new NullReferenceException();
    }

    public void Update(Product product)
    {
        var productUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId) ?? throw new NullReferenceException();
        productUpdate.ProductName = product.ProductName;
        productUpdate.CategoryId = product.CategoryId;
        productUpdate.UnitPrice = product.UnitPrice;
        productUpdate.UnitsInStock = product.UnitsInStock;
        
    }
    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        return _products;
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        throw new NotImplementedException();
    }
}