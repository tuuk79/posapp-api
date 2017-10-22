namespace server.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
