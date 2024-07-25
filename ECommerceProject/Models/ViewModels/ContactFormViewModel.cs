using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models.ViewModels
{
    public class ContactFormViewModel
    {
        /// <summary>
        ///     The first name of the sender.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The last name of the sender.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The time this message was sent.
        /// </summary>
        [Display(Name = "Time Sent")]
        public DateTime TimeSent { get; set; }

        /// <summary>
        ///     Whether this sender wants to be contacted by email or phone.
        /// </summary>
        [Display(Name = "Contact Preference")]
        public string ContactPreference { get; set; }

        /// <summary>
        ///     The sender's email address.
        /// </summary>
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     The sender's phone number.
        /// </summary>
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone #")]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     The subject of the message.
        /// </summary>
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     The message itself.
        /// </summary>
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
