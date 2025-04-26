using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Purchases.DeletePurchase;

/// <summary>
/// Command for deleting a purchase
/// </summary>
public record DeletePurchaseCommand : IRequest<DeletePurchaseResponse>
{
    /// <summary>
    /// The unique identifier of the purchase to delete
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of DeleteUserCommand
    /// </summary>
    /// <param name="id">The ID of the purchase to delete</param>
    public DeletePurchaseCommand(Guid id)
    {
        Id = id;
    }
}
