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

    public List<Product> GetAllByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }


    public void Add(Product product)
    {
        throw new NotImplementedException();
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