using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicturePath { get; set; }

        [Display(Name = "Preferred Currency")]
        public Currency PreferredCurrency { get; set; }
    }
}
