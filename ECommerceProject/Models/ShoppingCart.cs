using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpiryDate { get; set; }
        public User? User { get; set; }
    }
}
