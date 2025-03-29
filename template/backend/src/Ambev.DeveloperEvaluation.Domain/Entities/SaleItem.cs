using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents an individual item within a sale, including quantity, pricing, and discounts.
    /// </summary>
    public class SaleItem : BaseEntity
    {
        /// <summary>
        /// Gets the product Id.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets the product obj.
        /// </summary>
        public required Product Product { get; set; }

        /// <summary>
        /// Gets the quantity of the product sold.
        /// Must be greater than zero.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets the unit price of the product at the time of sale.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets the discount applied to the product.
        /// This is a percentage value (e.g., 10 for 10% discount).
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets the total amount for this item after applying discounts.
        /// </summary>
        public decimal TotalAmount => Quantity * UnitPrice * (1 - Discount / 100);
    }
}
