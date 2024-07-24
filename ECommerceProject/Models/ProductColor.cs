using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ProductColors")]
    public class ProductColor
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string HexCode { get; set; }
    }
}
