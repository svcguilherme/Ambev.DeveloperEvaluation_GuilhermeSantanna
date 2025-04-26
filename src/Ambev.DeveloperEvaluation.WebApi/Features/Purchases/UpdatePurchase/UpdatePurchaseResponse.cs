using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.UpdatePurchase;



/// <summary>
/// API response model for CreatePurchase operation
/// </summary>
public class UpdatePurchaseResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }


    /// <summary>
    /// The Code of the Purchase(Internal Code)
    /// </summary>
    public string CodePurchase { get; set; } = string.Empty;

    /// <summary>
    /// The Name of the product
    /// </summary>
    public string PurchaseName { get; set; } = string.Empty;

    /// <summary>
    /// The CodeBar of the product
    /// </summary>
    public string CodeBar { get; set; }


    /// <summary>
    /// The Description of the product
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The Price of the Purchase
    /// </summary>
    public decimal Price { get; set; }

}
