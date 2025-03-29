namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.SaleItems
{
    /// <summary>
    /// Represents the response after creating a sale item.
    /// </summary>
    public class CreateSaleItemResponse
    {
        public required string ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalItemAmount { get; set; }
    }
}
