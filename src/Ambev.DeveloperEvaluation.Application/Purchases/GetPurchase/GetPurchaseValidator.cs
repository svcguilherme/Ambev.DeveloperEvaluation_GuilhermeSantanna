using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;
/// <summary>
/// Validator for GetPurchaseCommand
/// </summary>
public class GetPurchaseValidator : AbstractValidator<GetPurchaseCommand>
{
    /// <summary>
    /// Initializes validation rules for GetPurchaseCommand
    /// </summary>
    public GetPurchaseValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Purchase ID is required");
    }
}
