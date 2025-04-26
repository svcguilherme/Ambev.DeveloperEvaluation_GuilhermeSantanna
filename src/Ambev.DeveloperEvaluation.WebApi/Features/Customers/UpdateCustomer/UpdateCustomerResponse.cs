using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.UpdateCustomer;

/// <summary>
/// API response model for CreateCustomer operation
/// </summary>
public class UpdateCustomerResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Customer Code Id
    /// </summary>
    public string CustomerCodeId { get; set; } = string.Empty;

    /// <summary>
    /// The Customer Name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// The Customer Phone
    /// </summary>
    public string CustomerPhone { get; set; } = string.Empty;

    /// <summary>
    /// The Customer Email
    /// </summary>
    public string CustomerEmail { get; set; } = string.Empty;

    /// <summary>
    /// The Customer City
    /// </summary>
    public string CustomerCity { get; set; } = string.Empty;

    /// <summary>
    /// The Customer State
    /// </summary>
    public string CustomerState { get; set; } = string.Empty;

    /// <summary>
    /// The Customer Country
    /// </summary>
    public string CustomerCountry { get; set; } = string.Empty;

    /// <summary>
    /// The Customer Address
    /// </summary>
    public string CustommerAddress { get; set; } = string.Empty;
}
