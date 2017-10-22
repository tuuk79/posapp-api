namespace server.Models
{
    public class PaymentMethod : BaseEntity
    {
        public string CardType { get; set; }
        public int LastFourNumbers { get; set; }
    }
}
