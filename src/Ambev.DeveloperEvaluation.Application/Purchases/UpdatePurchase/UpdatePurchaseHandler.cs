using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Application.Purchases.UpdatePurchase;

/// <summary>
/// Handler for processing UpdatePurchaseCommand requests
/// </summary>
public class UpdatePurchaseHandler : IRequestHandler<UpdatePurchaseCommand, UpdatePurchaseResult>
{
    private readonly IPurchaseRepository _purchaseRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of UpdatePurchaseHandler
    /// </summary>
    /// <param name="purchaseRepository">The purchase repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for UpdatePurchaseCommand</param>
    public UpdatePurchaseHandler(IPurchaseRepository purchaseRepository, IMapper mapper, IPasswordHasher passwordHasher)
    {
        _purchaseRepository = purchaseRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the UpdatePurchaseCommand request
    /// </summary>
    /// <param name="command">The UpdatePurchase command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created purchase details</returns>
    public async Task<UpdatePurchaseResult> Handle(UpdatePurchaseCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdatePurchaseCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

    
        var purchase = _mapper.Map<Purchase>(command);

        var createdPurchase = await _purchaseRepository.Update(purchase.Id, purchase, cancellationToken);
        var result = _mapper.Map<UpdatePurchaseResult>(createdPurchase);
        return result;
    }
}
