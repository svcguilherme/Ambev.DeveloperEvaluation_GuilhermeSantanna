using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for Purchase Item entity operations
/// </summary>
public interface IPurchaseItemRepository
{
    /// <summary>
    /// Creates a purchase in the repository
    /// </summary>
    /// <param name="purchaseitem">The purchaseitemr to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created purchaseitem</returns>
    Task<PurchaseItem> CreateAsync(PurchaseItem purchaseItem, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a Purchase Item by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseitemr</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchaseitemr if found, null otherwise</returns>
    Task<PurchaseItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Purchase Item by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseitemr</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchaseitem if found, null otherwise</returns>
    Task<PurchaseItem?> Update(Guid id, PurchaseItem model, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lista of a Purchase Item
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list purchaseitem if found</returns>
    Task<List<PurchaseItem>> GetAllAsync(CancellationToken cancellationToken = default);


    /// <summary>
    /// Deletes a Purchase Item from the repository
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseitem to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the purchaseitem was deleted, false if not found</returns>
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
