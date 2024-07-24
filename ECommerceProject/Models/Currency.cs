using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Currency
    {
        [Key]
        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
