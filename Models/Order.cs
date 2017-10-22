using System.Collections.Generic;

namespace server.Models
{
    public class Order : BaseEntity
    {
        List<Product> Product { get; set; }
    }
}