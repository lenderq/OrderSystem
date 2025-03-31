namespace OrderSystem.Models.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
