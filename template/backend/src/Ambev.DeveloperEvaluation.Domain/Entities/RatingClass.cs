namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents the rating details of a product, including the average rating and the count of ratings.
    /// </summary>
    public class RatingClass
    {
        /// <summary>
        /// Gets or sets the average rating of the product.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the product to which the rating belongs.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property for the associated product.
        /// </summary>
        public Product Product { get; set; } = new Product();
    }
}
