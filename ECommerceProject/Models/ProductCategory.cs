using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Store))]
        public Store Store { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
