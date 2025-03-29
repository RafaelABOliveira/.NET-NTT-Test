namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.Rating
{
    /// <summary>
    /// Represents a rating response.
    /// </summary>
    public class RatingResponse
    {
        public required decimal Rate { get; set; }
        public required int Count { get; set; }
    }

}
