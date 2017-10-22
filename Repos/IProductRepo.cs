using server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Repos
{
    public interface IProductRepo 
    {
        //Order GetById(int id);
        //IEnumerable<Product> ListAll();
        //Product Add(Product entity);
        Task<bool> Update(Product entity);
        //void Delete(Product id);
    }
}
