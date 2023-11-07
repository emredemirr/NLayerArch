﻿using System.Linq.Expressions;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
{
    
}