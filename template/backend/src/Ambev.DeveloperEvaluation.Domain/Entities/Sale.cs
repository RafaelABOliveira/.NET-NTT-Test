using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a sale transaction in the system, including details such as 
    /// customer information, branch location, product list, and pricing breakdown.
    /// This entity follows domain-driven design principles and includes business rules validation.
    /// </summary>
    public class Sale : BaseEntity
    {
        /// <summary>
        /// Gets the unique sale number. It is a string bacause we can change the format in the future.
        /// This identifier is used for tracking sales transactions.
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets the date when the sale was made.
        /// This field is required and must be a valid date in the past or present.
        /// </summary>
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets the customer associated with the sale.
        /// This field must contain valid customer information.
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// Gets the total amount of the sale.
        /// This is the final amount after applying discounts.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets the branch where the sale was made.
        /// This should correspond to a valid store or location identifier.
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// Gets the list of products included in the sale.
        /// Each product entry must include quantity, unit price, and total item cost.
        /// </summary>
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();

        /// <summary>
        /// Indicates whether the sale has been cancelled.
        /// A cancelled sale is considered invalid and should not be processed further.
        /// </summary>
        public bool IsCancelled { get; set; } = false;
    }
}
