using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.DeletePurchase;




/// <summary>
/// Validator for DeletePurchaseRequest
/// </summary>
public class DeletePurchaseRequestValidator : AbstractValidator<DeletePurchaseRequest>
{
    /// <summary>
    /// Initializes validation rules for DeletePurchaseRequest
    /// </summary>
    public DeletePurchaseRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Purchase ID is required");
    }
}
