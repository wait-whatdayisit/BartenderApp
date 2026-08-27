namespace BartenderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public DateTime PlacedAt { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; } = false;
    }
}