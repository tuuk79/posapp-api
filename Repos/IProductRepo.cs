using server.Models;
using System.Collections.Generic;

namespace server.Repos
{
    interface IProductRepo<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
