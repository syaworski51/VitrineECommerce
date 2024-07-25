namespace ECommerceProject.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public string TargetSex { get; set; } = "Unisex";
        public decimal Price { get; set; }
        public List<Category>? Categories { get; set; }
        public List<ProductSize>? Sizes { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
