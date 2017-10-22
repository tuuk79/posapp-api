using System.Collections.Generic;

namespace server.Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Order> Order { get; set; }
        public List<PaymentMethod> PaymentMethod { get; set; }
    }
}
