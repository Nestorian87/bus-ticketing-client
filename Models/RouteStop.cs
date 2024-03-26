namespace BusTicketingSystem.Models
{
    public class Stop
    {
        public int Id { get; set; } 
        public GeoLocation? Location { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
