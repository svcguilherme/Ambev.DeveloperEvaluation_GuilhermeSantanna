using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation for Product entities.
/// </summary>
public static class ProductTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Product entities.
    /// </summary>
    private static readonly Faker<Product> ProductFaker = new Faker<Product>()
        .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
        .RuleFor(p => p.Price, f => f.Random.Decimal(1, 1000)) // Price now more flexible
        .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
        .RuleFor(p => p.CodeBar, f => f.Random.ReplaceNumbers("############")); // 12-digit barcode style

    /// <summary>
    /// Generates a valid Product entity.
    /// </summary>
    public static Product GenerateValidProduct()
    {
        return ProductFaker.Generate();
    }

    /// <summary>
    /// Generates a valid product price as a string.
    /// </summary>
    public static string GeneratePrice()
    {
        return new Faker().Commerce.Price();
    }

    /// <summary>
    /// Generates a valid description for a product.
    /// </summary>
    public static string GenerateDescriptionProduct()
    {
        return new Faker().Commerce.ProductDescription();
    }

    /// <summary>
    /// Generates a valid product name.
    /// </summary>
    public static string GenerateName()
    {
        return new Faker().Commerce.ProductName();
    }
}
