using System.Collections.Generic;

namespace server.Models
{
    public class Order
    {
        public int Id { get; set; }
        List<Product> Product { get; set; }
    }
}