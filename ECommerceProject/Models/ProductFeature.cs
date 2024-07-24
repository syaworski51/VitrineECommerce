namespace ECommerceProject.Models
{
    public class ProductFeature
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
    }
}
