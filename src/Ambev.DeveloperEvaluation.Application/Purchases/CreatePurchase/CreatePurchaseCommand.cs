using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

/// <summary>
/// Command for creating a new purchase.
/// </summary>
/// <remarks>
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CreateProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateUserCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreatePurchaseCommand : IRequest<CreatePurchaseResult>
{

    /// <summary>
    /// The BranchName of the Purchase was made
    /// </summary>
    public string BranchName { get; private set; } = string.Empty;

    /// <summary>
    /// The code of the Purchase
    /// </summary>
    public string PurchaseCode { get; private set; } = string.Empty;

    /// <summary>
    /// The Customer of the Purchase
    /// </summary>
    public Customer Customer { get; set; }

    /// <summary>
    /// The date of the Purchase was mde
    /// </summary>
    public DateOnly PurchaseDate { get; set; } = new DateOnly();

    /// <summary>
    /// The Total of the Purchase
    /// </summary>
    public decimal TotalPurchase { get; set; }

    /// <summary>
    /// The Total Discount of the Purchase
    /// </summary>
    public decimal TotalDiscount { get; set; }

    /// <summary>
    /// The items of the Purchase
    /// </summary>
    public List<PurchaseItem> PurchaseItems { get; set; }

    /// <summary>
    /// The status of the Purchase
    /// </summary>
    public PurchaseStatus PurchaseStatus { get; set; }



    public ValidationResultDetail Validate()
    {
        var validator = new CreatePurchaseCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}