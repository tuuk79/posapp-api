using System.Linq;
using server.Models;

namespace server.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{Access = true, Employee= true},
                new User{Access = true, Employee= true},
                new User{Access = true, Employee= false},
                new User{Access = true, Employee= false},

            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();


            var addresses = new Address[]
            {
                new Address{Street= "12 Pine", State = "IL"},
                new Address{Street= "100 Weston", State = "IL"},
                new Address{Street= "120 Gold", State = "IN"},
                new Address{Street= "11 Clark", State = "MI"}

            };
            foreach (Address s in addresses)
            {
                context.Address.Add(s);
            }
            context.SaveChanges();

            var payments = new PaymentMethod[]
            {
                new PaymentMethod{CardType = "Master", LastFourNumbers = 1234},
                new PaymentMethod{CardType = "Visa", LastFourNumbers = 4321},
                new PaymentMethod{CardType = "Discovery", LastFourNumbers = 9876},
                new PaymentMethod{CardType = "American Express", LastFourNumbers = 6789}
            };
            foreach (PaymentMethod s in payments)
            {
                context.PaymentMethods.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Name = "GI Joe", Price = 5.49},
                new Product{Name = "Apple's Amazing Object", Price = 12.00},
                new Product{Name = "Kitchen Item", Price = 50.22},
                new Product{Name = "Auto Supplies", Price = 45.29}
            };
            
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer{Name = "Steve"},
                new Customer{Name = "Sean"},
                new Customer{Name = "Mike"},
                new Customer{Name = "Mary"},
            };
            foreach 
                (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();
        }
    }
}
