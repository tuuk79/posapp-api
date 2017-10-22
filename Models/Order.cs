using System.Collections.Generic;

namespace server.Models
{
    public class Order : BaseEntity
    {
        public List<Product> Product { get; set; }
    }
}