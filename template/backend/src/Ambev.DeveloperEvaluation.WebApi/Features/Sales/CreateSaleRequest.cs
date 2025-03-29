using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales
{
    /// <summary>
    /// Represents the request to create a sale.
    /// </summary>
    public class CreateSaleRequest
    {
        public required string SaleNumber { get; set; }
        public required DateTime SaleDate { get; set; }
        public required string Customer { get; set; }
        public required decimal TotalAmount { get; set; }
        public required string Branch { get; set; }
        public required List<SaleItem> Items { get; set; } = new();
        public bool IsCancelled { get; set; } = false;
    }


}
