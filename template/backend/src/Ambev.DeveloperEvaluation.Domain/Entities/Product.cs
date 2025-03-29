using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a product in the system, including pricing, category, and rating information.
    /// This entity follows domain-driven design principles and includes business rules validation.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title of the product.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category to which the product belongs.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the product image.
        /// </summary>
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Rating.
        /// </summary>
        public RatingClass Rating { get; set; } = new RatingClass();
    }
}
