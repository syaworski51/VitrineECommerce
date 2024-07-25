using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "User")]
        public User? User { get; set; }

        [Display(Name = "Date Placed")]
        public DateTime DatePlaced { get; set; }

        [Display(Name = "Billing Address")]
        public Address BillingAddress { get; set; }

        [Display(Name = "Shipping Address")]
        public Address ShippingAddress { get; set; }

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
