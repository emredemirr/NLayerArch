﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class OrderManager : IOrderService
{
    private readonly IOrderDal _orderDal;

    public OrderManager(IOrderDal orderDal)
    {
        _orderDal = orderDal;
    }
    
    public List<Order> GetAll()
    {
        return _orderDal.GetAll();
    }

    public void Add(Order order)
    {
        _orderDal.Add(order);
    }

    public void Delete(Order order)
    {
        _orderDal.Delete(order);
    }

    public void Update(Order order)
    {
        _orderDal.Update(order);
    }
}