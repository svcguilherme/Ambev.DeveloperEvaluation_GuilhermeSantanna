using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.Tests;

public class PurchaseTestDataTests
{
    [Fact]
    public void GenerateValidPurchase_ShouldReturnValidPurchase()
    {
        var purchase = PurchaseTestData.GenerateValidPurchase();

        purchase.Should().NotBeNull();
        purchase.BranchName.Should().NotBeNullOrEmpty();
        purchase.TotalPurchase.Should().BeGreaterThan(0);
        purchase.PurchaseDate.Should().NotBe(default);
    }

    [Fact]
    public void GeneratePrice_ShouldReturnPositiveDouble()
    {
        var price = PurchaseTestData.GeneratePrice();

        price.Should().BeGreaterThan(0);
    }

    [Fact]
    public void GenerateQuantity_ShouldReturnPositiveLong()
    {
        var quantity = PurchaseTestData.GenerateQuantity();

        quantity.Should().BeGreaterThan(0);
    }
}
