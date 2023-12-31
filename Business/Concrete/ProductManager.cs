﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    
    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public List<Product> GetAllByCategory(int id)
    {
        return _productDal.GetAll(p=>p.CategoryId == id);
    }
    
    public List<Product> GetByUnitPrice(decimal min, decimal max)
    {
        return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
    }
    
    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(Product product)
    {
        _productDal.Delete(product);
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}