using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;

/// <summary>
/// Validator for CreateCustomerCommand that defines validation rules for customer creation command.
/// </summary>
public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateCustomerCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be in valid format (using EmailValidator)
    /// - CustomerName: Required, must be between 3 and 50 characters
    /// - CustomerAddress: Required, must be between 3 and 50 characters
    /// - CustomerCodeId: Required, must be between 3 and 50 characters
    /// - CustomerName: Required, must be between 3 and 150 characters
    /// - CustomerPhone: Required, have to be a pattern
    /// - CustomerCity: Required, must be between 3 and 150 characters
    /// - CustomerState: Required, have to be 2 characteres
    /// </remarks>
    public CreateCustomerCommandValidator()
    {
        RuleFor(customer => customer.CustomerEmail).SetValidator(new EmailValidator());
        RuleFor(customer => customer.CustomerName).NotEmpty().Length(3, 150);
        RuleFor(customer => customer.CustomerPhone).Matches(@"^\+?[1-9]\d{1,14}$");
        RuleFor(customer => customer.CustomerCodeId).NotEmpty().Length(3, 50); ;
        RuleFor(customer => customer.CustommerAddress).NotEmpty().Length(3, 200); ;
        RuleFor(customer => customer.CustomerCity).NotEmpty().Length(3, 100); ;
        RuleFor(customer => customer.CustomerState).NotEmpty().Length(2, 2); ;
        RuleFor(customer => customer.CustomerCountry).NotEmpty().Length(3, 200); ;
    }
}