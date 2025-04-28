using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class PurchaseTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Purchase entities.
    /// </summary>
    private static readonly Faker<Purchase> PurchaseFaker = new Faker<Purchase>()
        .RuleFor(p => p.BranchName, f => f.Company.CompanyName())
        .RuleFor(p => p.TotalPurchase, f => f.PickRandom(4 ,8,10, 11)*100)
        .RuleFor(p => p.PurchaseDate, f => f.Date.PastDateOnly());

    /// <summary>
    /// Generates a valid Purchase entity.
    /// </summary>
    public static Purchase GenerateValidPurchase()
    {
        return PurchaseFaker.Generate();
    }

    /// <summary>
    /// Generates a valid random price.
    /// </summary>
    public static double GeneratePrice()
    {
        return new Faker().Random.Double(1, 1000);
    }

    /// <summary>
    /// Generates a valid random quantity.
    /// </summary>
    public static long GenerateQuantity()
    {
        return new Faker().Random.Long(1, 1000);
    }
}
