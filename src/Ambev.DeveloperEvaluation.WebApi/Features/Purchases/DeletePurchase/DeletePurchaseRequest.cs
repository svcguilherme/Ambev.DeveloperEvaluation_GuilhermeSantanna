namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.DeletePurchase;

/// <summary>
/// Request model for deleting a purchase
/// </summary>
/// 

public class DeletePurchaseRequest
{
    /// <summary>
    /// The unique identifier of the purchase to delete
    /// </summary>
    public Guid Id { get; set; }
}
