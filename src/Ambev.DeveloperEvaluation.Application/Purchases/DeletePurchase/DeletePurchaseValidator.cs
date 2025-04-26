using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Purchases.DeletePurchase;

/// <summary>
/// Validator for DeletePurchaseCommand
/// </summary>
public class DeletePurchaseValidator : AbstractValidator<DeletePurchaseCommand>
{
    /// <summary>
    /// Initializes validation rules for DeletePurchaseCommand
    /// </summary>
    public DeletePurchaseValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Purchase ID is required");
    }
}
