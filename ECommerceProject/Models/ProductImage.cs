using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ProductImages")]
    public class ProductImage
    {
        public Guid Id { get; set; }
        public DateTime DateUploaded { get; set; }
        public Store Store { get; set; }
        public Product Item { get; set; }
        public string Caption { get; set; }
        public string Path { get; set; }
        public int Index { get; set; }
    }
}
