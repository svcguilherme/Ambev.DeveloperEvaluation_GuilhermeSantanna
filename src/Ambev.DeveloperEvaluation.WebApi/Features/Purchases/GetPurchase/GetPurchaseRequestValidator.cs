using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchase;



/// <summary>
/// Validator for GetPurchaseRequest
/// </summary>
public class GetPurchaseRequestValidator : AbstractValidator<GetPurchaseRequest>
{
    /// <summary>
    /// Initializes validation rules for GetPurchaseRequest
    /// </summary>
    public GetPurchaseRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Purchase ID is required");
    }
}
