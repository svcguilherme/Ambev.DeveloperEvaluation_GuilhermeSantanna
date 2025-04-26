namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;

/// <summary>
/// Represents the response returned after successfully creating a new customer.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created customer,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class UpdateCustomerResult
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
