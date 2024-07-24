namespace ECommerceProject.Models
{
    public class ProductReviewVote
    {
        public Guid Id { get; set; }
        public DateTime DateCasted { get; set; }
        public ProductReview Review { get; set; }
        public User User { get; set; }
        public bool IsReviewHelpful { get; set; }
    }
}
