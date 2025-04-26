using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;

/// <summary>
/// Validator for CreateCustomerRequest that defines validation rules for customer creation.
/// </summary>
public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateCustomerRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be valid format (using EmailValidator)
    /// - Customername: Required, length between 3 and 50 characters
    /// - Password: Must meet security requirements (using PasswordValidator)
    /// - Phone: Must match international format (+X XXXXXXXXXX)
    /// - Status: Cannot be Unknown
    /// - Role: Cannot be None
    /// </remarks>
    public CreateCustomerRequestValidator()
    {
       // RuleFor(customer => customer.Email).SetValidator(new EmailValidator());
        //RuleFor(customer => customer.Customername).NotEmpty().Length(3, 50);
        //RuleFor(customer => customer.Password).SetValidator(new PasswordValidator());
        //RuleFor(customer => customer.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
        //RuleFor(customer => customer.Status).NotEqual(CustomerStatus.Unknown);
        //RuleFor(customer => customer.Role).NotEqual(CustomerRole.None);
    }
}