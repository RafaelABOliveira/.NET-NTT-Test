
using Ambev.DeveloperEvaluation.WebApi.Features.Products.Rating;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Represents the response after creating a product.
    /// </summary>
    public class CreateProductResponse
    {
        public required string Title { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Image { get; set; }
        public required RatingResponse Rating { get; set; } 

    }
}
