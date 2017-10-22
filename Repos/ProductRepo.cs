using System;
using System.Collections.Generic;
using server.Models;
using server.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace server.Repos
{
    public class ProductRepo<T> : IProductRepo<T> where T : BaseEntity
    {
        /// <summary>
        /// Product Repo Pattern
        /// </summary>
        /// 
        /// <typeparam name="T"></typeparam>

        private OrderContext _orderContext;

        public ProductRepo(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public T Add(T entity)
        {
            _orderContext.Set<T>().Add(entity);
            _orderContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _orderContext.Set<T>().Remove(entity);
            _orderContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _orderContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ListAll()
        {
            return _orderContext.Set<T>().AsEnumerable();
        }

        public void Update(T entity)
        {
            _orderContext.Entry(entity).State = EntityState.Modified;
            _orderContext.SaveChanges();
        }
    }
}
