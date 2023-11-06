using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : ICustomerDal
{
    public void Add(Customer entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Customer entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public void Update(Customer entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
    {
        using (var context = new NorthwindContext())
        {
            return filter == null 
                ? context.Set<Customer>().ToList() 
                : context.Set<Customer>().Where(filter).ToList();
        }
    }

    public Customer Get(Expression<Func<Customer, bool>> filter)
    {
        using (var context = new NorthwindContext())
        {
            return context.Set<Customer>().SingleOrDefault(filter);
        }
    }
}