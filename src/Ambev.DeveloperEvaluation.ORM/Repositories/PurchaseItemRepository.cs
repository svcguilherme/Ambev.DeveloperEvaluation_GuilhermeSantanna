using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of IPurchaseItemRepository using Entity Framework Core
/// </summary>
public class PurchaseItemRepository : IPurchaseItemRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of PurchaseItemRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public PurchaseItemRepository(DefaultContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new purchaseItem in the database
    /// </summary>
    /// <param name="purchaseItem">The purchaseItem to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created purchaseItem</returns>
    public async Task<PurchaseItem> CreateAsync(PurchaseItem purchaseItem, CancellationToken cancellationToken = default)
    {
        await _context.PurchaseItems.AddAsync(purchaseItem, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return purchaseItem;
    }

    /// <summary>
    /// Retrieves a Purchase Item by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the Puchase Item</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchaseItem if found, null otherwise</returns>
    public async Task<PurchaseItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.PurchaseItems.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Update a purchaseItem by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseItem</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchaseItem if found, null otherwise</returns>
    public async Task<PurchaseItem?> Update(Guid id, PurchaseItem model, CancellationToken cancellationToken = default)
    {
        var purchaseItem = await _context.PurchaseItems.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);

        if (purchaseItem != null)
        {
            purchaseItem.UnitPrice = model.UnitPrice;
            purchaseItem.Quantity = model.Quantity;
            purchaseItem.Product = model.Product;
            _context.Entry(purchaseItem).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);

        }
        else
        {
            purchaseItem = new PurchaseItem();
        }

        return purchaseItem;
    }

    /// <summary>
    /// Update a PurchaseItem by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseItem</param>
    /// <returns>The list of purchase if found</returns>
    public async Task<List<PurchaseItem>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.PurchaseItems.ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Deletes a PurchaseItem from the database
    /// </summary>
    /// <param name="id">The unique identifier of the purchaseItem to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the purchaseItem was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var purchase = await GetByIdAsync(id, cancellationToken);
        if (purchase == null)
            return false;

        _context.PurchaseItems.Remove(purchase);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }


}
