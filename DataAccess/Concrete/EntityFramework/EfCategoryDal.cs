using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : ICategoryDal
{
    public void Add(Category entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Category entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public void Update(Category entity)
    {
        //IDispossable pattern implementation of C#
        using (var context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
    {
        using (var context = new NorthwindContext())
        {
            return filter == null 
                ? context.Set<Category>().ToList() 
                : context.Set<Category>().Where(filter).ToList();
        }
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        using (var context = new NorthwindContext())
        {
            return context.Set<Category>().SingleOrDefault(filter);
        }
    }
}