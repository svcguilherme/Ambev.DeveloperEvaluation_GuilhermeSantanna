using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;

/// <summary>
/// Response model for GetCustomer operation
/// </summary>
public class GetCustomerResult
{
    /// <summary>
    /// The unique identifier of the customer
    /// </summary>
    public Guid Id { get; set; }


    /// <summary>
    /// The customer's full name
    /// </summary>
    public string CustomerCodeId { get; set; } = string.Empty;


    /// <summary>
    /// The customer's full name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// The customer's email address
    /// </summary>
    public string CustomerEmail { get; set; } = string.Empty;

    /// <summary>
    /// The customer's phone
    /// </summary>
    public string CustomerPhone { get; set; } = string.Empty;

    /// <summary>
    /// The customer's address
    /// </summary>
    public string CustomerAddress { get; set; } = string.Empty;

    /// <summary>
    /// The customer's city
    /// </summary>
    public string CustomerCity { get; set; } = string.Empty;

    /// <summary>
    /// The customer's state 
    /// </summary>
    public string CustomerState { get; set; } = string.Empty;

    /// <summary>
    /// The customer's country 
    /// </summary>
    public string CustomerCountry { get; set; } = string.Empty;


}
