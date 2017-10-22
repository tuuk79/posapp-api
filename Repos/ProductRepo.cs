using System;
using System.Collections.Generic;
using server.Models;
using server.Data;

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
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
