using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;



/// <summary>
/// Command for retrieving a purchase by their ID
/// </summary>
public record GetPurchaseCommand : IRequest<GetPurchaseResult>
{
    /// <summary>
    /// The unique identifier of the purchase to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of GetUserCommand
    /// </summary>
    /// <param name="id">The ID of the purchase to retrieve</param>
    public GetPurchaseCommand(Guid id)
    {
        Id = id;
    }
}
