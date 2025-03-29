using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for SaleItem entity operations (just creation)
    /// </summary>
    public interface ISaleItemRepository
    {
        /// <summary>
        /// Creates a new SaleItem in the repository
        /// </summary>
        /// <param name="saleItem">The SaleItem entity to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created SaleItem entity</returns>
        Task<SaleItem> CreateAsync(SaleItem saleItem, CancellationToken cancellationToken = default);
    }
}
