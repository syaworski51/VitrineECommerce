using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Addresses")]
    public class Address
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string? Line2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool IsDefaultAddress { get; set; }
    }
}
