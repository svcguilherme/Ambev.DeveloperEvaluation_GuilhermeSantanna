using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// API response model for CreateProduct operation
/// </summary>
public class GetProductResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }


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

}
