namespace server.Models
{
    public class User : BaseEntity
    {
        public bool Access { get; set; }
        public bool Employee { get; set; }
    }
}
