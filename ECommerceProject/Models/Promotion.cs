using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Promotions")]
    public class Promotion
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Amount Off")]
        public decimal AmountOff { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive
        {
            get
            {
                DateTime currentTime = DateTime.Now;
                return currentTime.CompareTo(StartDate) >= 0 && currentTime.CompareTo(EndDate) <= 0;
            }
        }
    }
}
