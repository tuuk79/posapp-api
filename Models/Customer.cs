using System.Collections.Generic;

namespace server.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Order> Order { get; set; }
        public List<PaymentMethod> PaymentMethod { get; set; }
    }
}
