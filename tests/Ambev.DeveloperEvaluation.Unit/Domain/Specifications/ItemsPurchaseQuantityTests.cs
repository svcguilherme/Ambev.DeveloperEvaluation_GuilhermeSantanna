using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentAssertions;
using FluentValidation.TestHelper;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Validation.Tests;

public class PurchaseItemValidatorTests
{
    private readonly PurchaseItemValidator _validator = new();

    [Fact]
    public void Should_Have_Error_When_Quantity_Greater_Than_20()
    {
        var item = new PurchaseItem { Quantity = 21 };

        var result = _validator.TestValidate(item);

        result.ShouldHaveValidationErrorFor(x => x.Quantity)
            .WithErrorMessage("A maximum of 20 items per product purchase is allowed!");
    }

    [Fact]
    public void Should_Have_Error_When_Discount_With_Quantity_Less_Than_4()
    {
        var item = new PurchaseItem { Quantity = 3, TotalDiscount = 5 };

        var result = _validator.TestValidate(item);

        result.ShouldHaveValidationErrorFor(x => x);
    }

    [Fact]
    public void Should_Have_Error_When_Discount_Exceeds_10_Percent_For_Quantity_Between_4_And_10()
    {
        var item = new PurchaseItem { Quantity = 5, TotalDiscount = 15 };

        var result = _validator.TestValidate(item);

        result.ShouldHaveValidationErrorFor(x => x);
    }

    [Fact]
    public void Should_Not_Have_Error_When_Discount_Is_Valid_For_Quantity_Between_4_And_10()
    {
        var item = new PurchaseItem { Quantity = 6, TotalDiscount = 8 };

        var result = _validator.TestValidate(item);

        result.ShouldNotHaveValidationErrorFor(x => x);
    }

    [Fact]
    public void Should_Have_Error_When_Discount_Exceeds_20_Percent_For_Quantity_Between_10_And_20()
    {
        var item = new PurchaseItem { Quantity = 15, TotalDiscount = 25 };

        var result = _validator.TestValidate(item);

        result.ShouldHaveValidationErrorFor(x => x);
    }

    [Fact]
    public void Should_Not_Have_Error_When_Discount_Is_Valid_For_Quantity_Between_10_And_20()
    {
        var item = new PurchaseItem { Quantity = 12, TotalDiscount = 18 };

        var result = _validator.TestValidate(item);

        result.ShouldNotHaveValidationErrorFor(x => x);
    }
} 
