using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of IPurchaseRepository using Entity Framework Core
/// </summary>
public class PurchaseRepository : IPurchaseRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of PurchaseRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public PurchaseRepository(DefaultContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new user in the database
    /// </summary>
    /// <param name="user">The user to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created user</returns>
    public async Task<Purchase> CreateAsync(Purchase purchase, CancellationToken cancellationToken = default)
    {
        await _context.Purchases.AddAsync(purchase, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return purchase;
    }

    /// <summary>
    /// Retrieves a user by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    public async Task<Purchase?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Purchases.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Update a user by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    public async Task<Purchase?> Update(Guid id, Purchase model, CancellationToken cancellationToken = default)
    {
        var purchase = await _context.Purchases.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);

        if (purchase != null)
        {
            purchase.Customer = model.Customer;
            purchase.PurchaseItems = model.PurchaseItems;
            purchase.PurchaseStatus = model.PurchaseStatus;
            purchase.TotalPurchase = model.PurchaseItems.Sum(o => o.TotalPrice - o.TotalDiscount);
            purchase.TotalDiscount = model.PurchaseItems.Sum(o => o.TotalDiscount);
            purchase.PurchaseStatus = model.PurchaseStatus;

            _context.Entry(purchase).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);

        }
        else
        {
            purchase = new Purchase();
        }

        return purchase;
    }

    /// <summary>
    /// Update a Purchase by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <returns>The list of purchase if found</returns>
    public async Task<List<Purchase>> GetAllAsync()
    {
        return await _context.Purchases.ToListAsync();
    }

    /// <summary>
    /// Deletes a Purchase from the database
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the user was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var purchase = await GetByIdAsync(id, cancellationToken);
        if (purchase == null)
            return false;

        _context.Purchases.Remove(purchase);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }


}
