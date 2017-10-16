namespace server.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public int LastFourNumbers { get; set; }
    }
}
