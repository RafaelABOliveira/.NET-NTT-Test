using Ambev.DeveloperEvaluation.WebApi.Features.Products.Rating;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Represents the request to create a product.
    /// </summary>
    public class CreateProductRequest
    {
        public required string Title { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Image { get; set; }
        public required RatingRequest Rating { get; set; } = new RatingRequest { Rate = 0, Count = 0 };
    }
}
