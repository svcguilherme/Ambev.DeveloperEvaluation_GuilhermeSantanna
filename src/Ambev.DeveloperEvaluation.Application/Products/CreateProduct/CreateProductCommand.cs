using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;



namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
/// <summary>
/// Command for creating a new product.
/// </summary>
/// <remarks>
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="UpdateProductResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateUserCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateProductCommand : IRequest<CreateProductResult>
{

    /// <summary>
    /// The Code of the Product(Internal Code)
    /// </summary>
    public string CodeProduct { get; set; } = string.Empty;

    /// <summary>
    /// The Name of the product
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// The CodeBar of the product
    /// </summary>
    public string CodeBar { get; set; }


    /// <summary>
    /// The Description of the product
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The Price of the Product
    /// </summary>
    public decimal Price { get; set; }



    public ValidationResultDetail Validate()
    {
        var validator = new CreateProductCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}