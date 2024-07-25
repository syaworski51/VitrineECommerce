using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        /// <summary>
        ///     The unique ID of this product category.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The store that uses this product category.
        /// </summary>
        [Display(Name = "Store")]
        public Store Store { get; set; }

        /// <summary>
        ///     The product that belongs to the specified category.
        /// </summary>
        [Display(Name = "Product")]
        public Product Product { get; set; }

        /// <summary>
        ///     The category that the product belongs to.
        /// </summary>
        [Display(Name = "Category")]
        public Category Category { get; set; }
    }
}
