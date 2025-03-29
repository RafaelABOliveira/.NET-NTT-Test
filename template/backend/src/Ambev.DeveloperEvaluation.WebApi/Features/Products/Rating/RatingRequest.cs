namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.Rating
{
    /// <summary>
    /// Represents a rating request.
    /// </summary>
    public class RatingRequest
    {
        public required decimal Rate { get; set; }
        public required int Count { get; set; }
    }
}
