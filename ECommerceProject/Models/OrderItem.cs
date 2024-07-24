namespace ECommerceProject.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Store Store { get; set; }
        public Order Order { get; set; }
        public Product Item { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }
        public decimal Price { get; set; }
    }
}
