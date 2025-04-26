namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Represents the response returned after successfully creating a new product.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created product,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class UpdateProductResult
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

}
