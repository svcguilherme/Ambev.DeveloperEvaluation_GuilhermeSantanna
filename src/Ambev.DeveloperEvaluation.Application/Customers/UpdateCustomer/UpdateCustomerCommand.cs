using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;

/// <summary>
/// Command for creating a new customer.
/// </summary>
/// <remarks>
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="UpdateCustomerResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="UpdateCustomerCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class UpdateCustomerCommand : IRequest<UpdateCustomerResult>
{
    /// <summary>
    /// Gets or sets the Customer Code Id of the customer to be created.
    /// </summary>
    public string CustomerCodeId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the customername of the customer to be created.
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the phone number for the customer.
    /// </summary>
    public string CustomerPhone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address for the customer.
    /// </summary>
    public string CustomerEmail { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Ciy address for the customer.
    /// </summary>
    public string CustomerCity { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the State address for the customer.
    /// </summary>
    public string CustomerState { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the Country address for the customer.
    /// </summary>
    public string CustomerCountry { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the Address address for the customer.
    /// </summary>
    public string CustommerAddress { get; set; } = string.Empty;


    public ValidationResultDetail Validate()
    {
        var validator = new UpdateCustomerCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}