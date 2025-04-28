using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Bogus;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.Tests;

public class PurchaseTestDataTests
{
    [Fact]
    public void GenerateValidPurchase_ShouldReturnValidPurchase()
    {
        var product = ProductTestData.GenerateValidProduct();

        product.Should().NotBeNull();
        product.ProductName.Should().NotBeNullOrEmpty();
        product.Price.Should().BeGreaterThan(0);
        product.CodeBar.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GeneratePrice_ShouldReturnPositiveDouble()
    {
        var price = ProductTestData.GeneratePrice();

        price.Should().BeGreaterThan(0);
    }

    [Fact]
    public void GenerateCodeBar_ShouldBeValid()
    {
        var name = ProductTestData.GenerateCodebar();
    }
}
