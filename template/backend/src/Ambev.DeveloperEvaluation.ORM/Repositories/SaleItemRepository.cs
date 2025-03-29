using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Implementation of ISaleItemRepository
    /// </summary>
    public class SaleItemRepository : ISaleItemRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of SaleItemRepository
        /// </summary>
        /// <param name="context">The database context</param>
        public SaleItemRepository(DefaultContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new sale item in the database
        /// </summary>
        /// <param name="saleItem">The sale item to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale item</returns>
        public async Task<SaleItem> CreateAsync(SaleItem saleItem, CancellationToken cancellationToken = default)
        {
            await _context.SalesItems.AddAsync(saleItem, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return saleItem;
        }
    }
}
