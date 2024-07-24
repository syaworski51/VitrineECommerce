namespace ECommerceProject.Models
{
    public class ProductReview
    {
        public Guid Id { get; set; }
        public DateTime DatePublished { get; set; }
        public User Author { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsProductRecommendedByAuthor { get; set; }
    }
}
