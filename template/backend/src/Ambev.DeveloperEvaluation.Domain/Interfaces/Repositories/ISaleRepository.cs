using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Sale entity operations (just creation)
    /// </summary>
    public interface ISaleRepository
    {
        /// <summary>
        /// Creates a new Sale in the repository
        /// </summary>
        /// <param name="sale">The Sale entity to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created Sale entity</returns>
        Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);
    }
}
