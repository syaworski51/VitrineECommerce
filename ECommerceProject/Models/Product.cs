using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Products")]
    public class Product
    {
        /// <summary>
        ///     The unique ID of this product.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     Shop Keeping Unit - Unique name created by the store owner to identify a product in their database.
        /// </summary>
        [Display(Name = "SKU")]
        public string SKU { get; set; }

        /// <summary>
        ///     Universal Product Code - Uniquely identifies this product universally.
        /// </summary>
        [Display(Name = "UPC")]
        public string UPC { get; set; }

        /// <summary>
        ///     The category of this product (ex. clothing, electronics, stationery, etc.).
        /// </summary>
        [Display(Name = "Category")]
        public string Category { get; set; }

        /// <summary>
        ///     The name of this product.
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        ///     A description of this product.
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        ///     If not null, a current promotion that has been applied to this product (ex. Buy 1 Get 1 Free, 20% off).
        ///     Null if there are no current promotions for this product.
        /// </summary>
        [ForeignKey(nameof(Promotion))]
        [Display(Name = "Promotion")]
        public Promotion? Promotion { get; set; }

        /// <summary>
        ///     The regular price of this product.
        /// </summary>
        [Display(Name = "Regular Price")]
        public decimal RegularPrice { get; set; }

        /// <summary>
        ///     The price this product is currently being sold for. Typically the same as the regular price,
        ///     except if there is a promotion for this product.
        /// </summary>
        [Display(Name = "Current Price")]
        public decimal CurrentPrice
        {
            get
            {
                // If there is a promotion for this product...
                if (Promotion != null)
                    // If the type of promotion is a fixed amount off (ex. $20 off)...
                    return Promotion.Type == "Fixed Amount" ?
                        RegularPrice - Promotion.AmountOff :  // Subtract the amount off from the regular price
                        RegularPrice * (1 - Promotion.AmountOff);  // Otherwise, deduct the % off from the regular price

                // If there is no promotion, return the regular price
                return RegularPrice;
            }
        }
    }
}
