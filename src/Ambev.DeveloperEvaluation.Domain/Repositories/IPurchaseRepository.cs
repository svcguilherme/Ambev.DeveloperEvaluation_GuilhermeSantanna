using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for Purchase entity operations
/// </summary>
public interface IPurchaseRepository
{
    /// <summary>
    /// Creates a purchase in the repository
    /// </summary>
    /// <param name="purchase">The purchase to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created Purchase</returns>
    Task<Purchase> CreateAsync(Purchase purchase, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a Purchase by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchase if found, null otherwise</returns>
    Task<Purchase?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Purchase by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the purchase</param>
    /// <param name="model">The unique identifier of the purhcase</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchase if found, Empty Purchase</returns>
    Task<Purchase?> Update(Guid id, Purchase model, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a Purchase by their unique identifier
    /// </summary>
    /// <returns>The list of purchase if found</returns>
    Task<List<Purchase>> GetAllAsync();

    /// <summary>
    /// Deletes Purchase from the repository
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the user was deleted, false if not found</returns>
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
