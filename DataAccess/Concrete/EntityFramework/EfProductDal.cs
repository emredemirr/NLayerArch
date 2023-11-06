﻿using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : IProductDal
{
    public void Add(Product entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Product entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public void Update(Product entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        using (var context = new NorthwindContext())
        {
            return filter == null 
                ? context.Set<Product>().ToList() 
                : context.Set<Product>().Where(filter).ToList();
        }
        
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        using (var context = new NorthwindContext())
        {
            return context.Set<Product>().SingleOrDefault(filter);
        }
    }
}