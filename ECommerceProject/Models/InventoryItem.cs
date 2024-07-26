using ECommerceProject.Models;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vetrina.Models
{
    [Table("InventoryItems")]
    public class InventoryItem
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Date Registered")]
        public DateTime DateRegistered { get; set; }

        [Display(Name = "Store")]
        public Store Store { get; set; }

        [Display(Name = "Location")]
        public Location? Location { get; set; }

        [Display(Name = "Product")]
        public Product Product { get; set; }

        [Display(Name = "Color")]
        public ProductColor? Color { get; set; }

        [Display(Name = "Size")]
        public ProductSize? Size { get; set; }
    }
}
