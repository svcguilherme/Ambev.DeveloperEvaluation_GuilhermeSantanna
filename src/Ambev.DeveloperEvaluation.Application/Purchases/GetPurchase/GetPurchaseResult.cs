using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;


namespace Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;
/// <summary>
/// Response model for GetPurchase operation
/// </summary>
public class GetPurchaseResult
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

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

}
