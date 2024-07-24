using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ProductSizes")]
    public class ProductSize
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
