﻿using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T:class, IEntity,new()
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll(Expression<Func<T,bool>> filter=null);
    T Get(Expression<Func<T,bool>> filter);
}