using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        public Guid Id { get; set; }
        public Store Store { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public Product Product { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }
        public decimal Price { get; set; }
    }
}
