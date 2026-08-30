namespace CafeFarhan.Models
{
    public enum OrderStatus
    {
        New = 0,
        Preparing = 1,
        Ready = 2,
        Completed = 3,
        Cancelled = 4
    }

    public class Order
    {
        public int Id { get; set; }

        public int TableNumber { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }
            = OrderStatus.New;

        public DateTime CreatedAt { get; set; }
            = DateTime.Now;

        public ICollection<OrderItem> Items { get; set; }
            = new List<OrderItem>();
    }
}