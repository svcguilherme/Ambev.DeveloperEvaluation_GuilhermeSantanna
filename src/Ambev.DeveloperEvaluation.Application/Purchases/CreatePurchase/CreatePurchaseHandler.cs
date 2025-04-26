using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

/// <summary>
/// Handler for processing CreatePurchaseCommand requests
/// </summary>
public class CreatePurchaseHandler : IRequestHandler<CreatePurchaseCommand, CreatePurchaseResult>
{
    private readonly IPurchaseRepository _purchaseRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreatePurchaseHandler
    /// </summary>
    /// <param name="purchaseRepository">The purchase repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreatePurchaseCommand</param>
    public CreatePurchaseHandler(IPurchaseRepository purchaseRepository, IMapper mapper, IPasswordHasher passwordHasher)
    {
        _purchaseRepository = purchaseRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreatePurchaseCommand request
    /// </summary>
    /// <param name="command">The CreatePurchase command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created purchase details</returns>
    public async Task<CreatePurchaseResult> Handle(CreatePurchaseCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreatePurchaseCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        //var existingPurchase = await _purchaseRepository.GetByEmailAsync(command.Email, cancellationToken);
       // if (existingPurchase != null)
       //     throw new InvalidOperationException($"Purchase with email {command.Email} already exists");

        var purchase = _mapper.Map<Purchase>(command);
       
        var createdPurchase = await _purchaseRepository.CreateAsync(purchase, cancellationToken);
        var result = _mapper.Map<CreatePurchaseResult>(createdPurchase);
        return result;
    }
}
