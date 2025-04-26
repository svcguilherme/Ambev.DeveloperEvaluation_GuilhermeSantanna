using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;

/// <summary>
/// Handler for processing GetUserCommand requests
/// </summary>
public class GetPurchaseHandler : IRequestHandler<GetPurchaseCommand, GetPurchaseResult>
{
    private readonly IUserRepository _purchaseRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetUserHandler
    /// </summary>
    /// <param name="purchaseRepository">The purchase repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetUserCommand</param>
    public GetPurchaseHandler(
        IUserRepository purchaseRepository,
        IMapper mapper)
    {
        _purchaseRepository = purchaseRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetUserCommand request
    /// </summary>
    /// <param name="request">The GetUser command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchase details if found</returns>
    public async Task<GetPurchaseResult> Handle(GetPurchaseCommand request, CancellationToken cancellationToken)
    {
        var validator = new GetPurchaseValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var purchase = await _purchaseRepository.GetByIdAsync(request.Id, cancellationToken);
        if (purchase == null)
            throw new KeyNotFoundException($"User with ID {request.Id} not found");

        return _mapper.Map<GetPurchaseResult>(purchase);
    }
}
