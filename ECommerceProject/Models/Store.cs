using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Stores")]
    public class Store
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Published")]
        public DateTime? DatePublished { get; set; }

        [Display(Name = "Owner")]
        public User Owner { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Domain")]
        public string Domain { get; set; }

        [Display(Name = "Default Currency")]
        public Currency DefaultCurrency { get; set; }

        [Display(Name = "File Storage Domain")]
        public string FileStorageDomain { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
