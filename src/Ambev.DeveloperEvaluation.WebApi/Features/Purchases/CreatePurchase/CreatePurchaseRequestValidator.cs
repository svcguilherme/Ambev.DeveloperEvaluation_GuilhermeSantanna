using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.CreatePurchase;



/// <summary>
/// Validator for CreatePurchaseRequest that defines validation rules for purchase creation.
/// </summary>
public class CreatePurchaseRequestValidator : AbstractValidator<CreatePurchaseRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreatePurchaseRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:

    /// </remarks>
    public CreatePurchaseRequestValidator()
    {
 //       RuleFor(purchase => purchase.Email).SetValidator(new EmailValidator());
        //RuleFor(purchase => purchase.Purchasename).NotEmpty().Length(3, 50);
        //RuleFor(purchase => purchase.Password).SetValidator(new PasswordValidator());
        //RuleFor(purchase => purchase.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        //RuleFor(purchase => purchase.Status).NotEqual(PurchaseStatus.Unknown);
        //RuleFor(purchase => purchase.Role).NotEqual(PurchaseRole.None);
    }
}