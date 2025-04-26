using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Purchases.DeletePurchase;

/// <summary>
/// Handler for processing DeletePurchaseCommand requests
/// </summary>
public class DeletePurchaseHandler : IRequestHandler<DeletePurchaseCommand, DeletePurchaseResponse>
{
    private readonly IPurchaseRepository _purchaseRepository;

    /// <summary>
    /// Initializes a new instance of DeletePurchaseHandler
    /// </summary>
    /// <param name="purchaseRepository">The purchase repository</param>
    /// <param name="validator">The validator for DeletePurchaseCommand</param>
    public DeletePurchaseHandler(
        IPurchaseRepository purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    /// <summary>
    /// Handles the DeletePurchaseCommand request
    /// </summary>
    /// <param name="request">The DeletePurchase command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The result of the delete operation</returns>
    public async Task<DeletePurchaseResponse> Handle(DeletePurchaseCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeletePurchaseValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var success = await _purchaseRepository.DeleteAsync(request.Id, cancellationToken);
        if (!success)
            throw new KeyNotFoundException($"Purchase with ID {request.Id} not found");

        return new DeletePurchaseResponse { Success = true };
    }
}
