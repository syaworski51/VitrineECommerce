using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Index")]
        public int Index { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Line 1")]
        public string Line1 { get; set; }

        [Display(Name = "Line 2")]
        public string? Line2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Default?")]
        public bool IsDefaultAddress { get; set; }
    }
}
