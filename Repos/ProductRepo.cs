using System;
using System.Collections.Generic;
using server.Models;
using server.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace server.Repos
{
    public class ProductRepo : IProductRepo
    {
        /// <summary>
        /// Product Repo Pattern
        /// Look at github https://github.com/DanWahlin/Angular-ASPNET-Core-CustomersService/blob/master/Angular-ASPNET-Core-CustomersService/Apis/CustomersController.cs
        /// </summary>
        /// 
        /// <typeparam name="Product"></typeparam>

        private OrderContext _orderContext;

        public ProductRepo(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        //public Product Add(Product entity)
        //{
        //    _orderContext.Add(entity);
        //    _orderContext.SaveChanges();
        //    return entity;
        //}

        //public void Delete(Product id)
        //{
        //    var product = _orderContext.Products.Find(id);

        //    _orderContext.Remove(product);
        //    _orderContext.SaveChanges();
        //}

        //public Order GetById(int id)
        //{
        //    return _orderContext.Orders
        //        .Include(c => c.Product)
        //        .SingleOrDefault(c => c.Id == id);
        //}

        //public IEnumerable<Product> ListAll()
        //{
        //    return _orderContext.Products.AsEnumerable();
        //}

        public async Task<bool> Update(Product entity)
        {
            _orderContext.Products.Attach(entity);
            _orderContext.Entry(entity).State = EntityState.Modified;
            await _orderContext.SaveChangesAsync();
            return true;
        }
    }
}
