using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ProductImages")]
    public class ProductImage
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Date Uploaded")]
        public DateTime DateUploaded { get; set; }

        [Display(Name = "Store")]
        public Store Store { get; set; }

        [Display(Name = "Item")]
        public Product Item { get; set; }

        [Display(Name = "Caption")]
        public string Caption { get; set; }

        [Display(Name = "Path")]
        public string Path { get; set; }

        [Display(Name = "Index")]
        public int Index { get; set; }
    }
}
