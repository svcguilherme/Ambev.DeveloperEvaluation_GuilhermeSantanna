using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.Tests;

public class CustomerTestDataTests
{
    [Fact]
    public void GenerateValidCustomer_ShouldReturnValidCustomer()
    {
        var customer = CustomerTestData.GenerateValidCustomer();

        customer.Should().NotBeNull();
        customer.CustomerEmail.Should().Contain("@");
        customer.CustomerPhone.Should().StartWith("+55");
        customer.CustomerCity.Should().NotBeNullOrEmpty();
        customer.CustomerState.Should().NotBeNullOrEmpty();
        customer.CustomerCountry.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GenerateValidEmail_ShouldReturnEmailWithAtSymbol()
    {
        var email = CustomerTestData.GenerateValidEmail();

        email.Should().Contain("@");
    }

    [Fact]
    public void GenerateInvalidEmail_ShouldNotContainAtSymbol()
    {
        var email = CustomerTestData.GenerateInvalidEmail();

        email.Should().NotContain("@");
    }

    [Fact]
    public void GenerateValidPhone_ShouldStartWithPlus55()
    {
        var phone = CustomerTestData.GenerateValidPhone();

        phone.Should().StartWith("+55");
        phone.Length.Should().BeGreaterThanOrEqualTo(13);
    }

    [Fact]
    public void GenerateInvalidPhone_ShouldNotMatchValidFormat()
    {
        var phone = CustomerTestData.GenerateInvalidPhone();

        phone.Should().NotStartWith("+55");
        phone.Length.Should().BeLessThan(13);
    }

    [Fact]
    public void GenerateCustomerName_ShouldReturnNonEmptyName()
    {
        var name = CustomerTestData.GenerateCustomerName();

        name.Should().NotBeNullOrEmpty();
        name.Should().Contain(" ");
    }

    [Fact]
    public void GenerateInvalidCustomerName_ShouldReturnInvalidName()
    {
        var name = CustomerTestData.GenerateInvalidCustomerName();

        name.Should().NotBeNullOrEmpty();
        name.Length.Should().BeGreaterThan(0);
    }

    [Fact]
    public void GenerateValidCountry_ShouldReturnCountryName()
    {
        var country = CustomerTestData.GenerateValidCountry();

        country.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GenerateValidAddress_ShouldReturnAddress()
    {
        var address = CustomerTestData.GenerateValidAddress();

        address.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GenerateValidCity_ShouldReturnCityName()
    {
        var city = CustomerTestData.GenerateValidCity();

        city.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GenerateValidState_ShouldReturnStateAbbreviation()
    {
        var state = CustomerTestData.GenerateValidState();

        state.Should().NotBeNullOrEmpty();
        state.Length.Should().Be(2);
    }
}
