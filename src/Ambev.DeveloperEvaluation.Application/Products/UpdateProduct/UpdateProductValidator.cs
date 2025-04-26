using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductCommand that defines validation rules for product creation command.
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Code product have to be defined
    /// - Price have to be greater than 0
    /// - Product Name have to be defined
    /// - Description have to be defined
    /// - CodeBar have to be defined and mininum lentgh is 9
    /// </remarks>
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.CodeProduct).NotEmpty();
        RuleFor(product => product.Price).GreaterThan(0);
        RuleFor(product => product.ProductName).NotEmpty();
        RuleFor(product => product.Description).NotEmpty();
        RuleFor(product => product.CodeBar).NotEmpty().MinimumLength(9);
    }
}