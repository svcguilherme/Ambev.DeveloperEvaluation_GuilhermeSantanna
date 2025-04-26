using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

/// <summary>
/// Validator for CreateUserCommand that defines validation rules for purchase creation command.
/// </summary>
public class CreatePurchaseCommandValidator : AbstractValidator<CreatePurchaseCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreatePurchaseCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - BranchName have to be defined
    /// - Customer have to be defined a code
    /// - TotalPurchase have to bem greather than 0
    /// - Purchase Items can't be 0
    /// </remarks>
    public CreatePurchaseCommandValidator()
    {

        RuleFor(purchase => purchase.BranchName).NotEmpty().Length(3,150);
        RuleFor(purchase => purchase.TotalPurchase).GreaterThan(0);
        RuleFor(purchase => purchase.PurchaseItems.Count()).GreaterThan(0);
        RuleFor(purchase => purchase.Customer.CustomerCodeId).NotEmpty();

     }
}