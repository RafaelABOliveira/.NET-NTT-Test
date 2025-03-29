namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.SaleItems
{
    /// <summary>
    /// Represents the request to create a sale item.
    /// </summary>
    public class CreateSaleItemRequest
    {
        public required string ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalItemAmount => Quantity * UnitPrice * (1 - Discount);
    }
}
