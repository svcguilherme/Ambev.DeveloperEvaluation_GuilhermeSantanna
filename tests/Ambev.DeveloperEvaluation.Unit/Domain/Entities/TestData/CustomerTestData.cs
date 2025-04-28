using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class CustomerTestData
{
    /// <summary>
    /// Configures the Faker to generate valid User entities.
    /// The generated users will have valid:
    /// - Username (using internet usernames)
    /// - Password (meeting complexity requirements)
    /// - Email (valid format)
    /// - Phone (Brazilian format)
    /// - Status (Active or Suspended)
    /// - Role (Customer or Admin)
    /// </summary>
    private static readonly Faker<Customer> CustomerFake = new Faker<Customer>()
        .RuleFor(u => u.CustomerName, f => f.Name.FullName())
        .RuleFor(u => u.CustomerCity, f => f.Address.City())
        .RuleFor(u => u.CustomerState, f => f.Address.StateAbbr())
        .RuleFor(u => u.CustomerCountry, f => f.Address.Country())
        .RuleFor(u => u.CustomerEmail, f => f.Internet.Email())
        .RuleFor(u => u.CustomerPhone, f => $"+55{f.Random.Number(11, 99)}{f.Random.Number(100000000, 999999999)}")
        .RuleFor(u => u.CustommerAddress, f => f.Name.ToString());

    
    public static Customer GenerateValidCustomer()
    {
        return CustomerFake;
    }

    /// <summary>
    /// Generates a valid User entity with randomized data.
    /// The generated user will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid User entity with randomly generated data.</returns>
    //;
    /// <summary>
    /// Generates a valid email address using Faker.
    /// The generated email will:
    /// - Follow the standard email format (user@domain.com)
    /// - Have valid characters in both local and domain parts
    /// - Have a valid TLD
    /// </summary>
    /// <returns>A valid email address.</returns>
    public static string GenerateValidEmail()
    {
        return new Faker().Internet.Email();
    }

    public static string GenerateValidPhone()
    {
        var faker = new Faker();
        return $"+55{faker.Random.Number(11, 99)}{faker.Random.Number(100000000, 999999999)}";
    }

    /// <summary>
    /// Generates a valid Customer Name.
    /// The generated Customer Name will:
    /// - Be between 3 and 150 characters
    /// - Use internet Name conventions
    /// - Contain only valid characters
    /// </summary>
    /// <returns>A valid Name.</returns>
    public static string GenerateInvalidCustomerName()
    {
        return new Faker().Lorem.Text();
    }

    /// <summary>
    /// Generates a valid Customer Name.
    /// The generated Customer Name will:
    /// - Be between 3 and 150 characters
    /// - Use internet Name conventions
    /// - Contain only valid characters
    /// </summary>
    /// <returns>A valid Name.</returns>
    public static string GenerateCustomerName()
    {
        return new Faker().Name.FullName();
    }



    /// <summary>
    /// Generates an invalid email address for testing negative scenarios.
    /// The generated email will:
    /// - Not follow the standard email format
    /// - Not contain the @ symbol
    /// - Be a simple word or string
    /// This is useful for testing email validation error cases.
    /// </summary>
    /// <returns>An invalid email address.</returns>
    public static string GenerateInvalidEmail()
    {
        var faker = new Faker();
        return faker.Lorem.Word();
    }

    
    /// <summary>
    /// Generates an invalid phone number for testing negative scenarios.
    /// The generated phone number will:
    /// - Not follow the Brazilian phone number format
    /// - Not have the correct length
    /// - Not start with the country code
    /// This is useful for testing phone validation error cases.
    /// </summary>
    /// <returns>An invalid phone number.</returns>
    public static string GenerateInvalidPhone()
    {
        return new Faker().Random.AlphaNumeric(5);
    }

    /// <summary>
    /// Generate a valid Country Name
    /// </summary>
    /// <returns>An invalid phone number.</returns>
    public static string GenerateValidCountry()
    {
        return new Faker().Address.Country();
    }

    /// <summary>
    /// Generate a valid Address 
    /// </summary>
    /// <returns>An invalid phone number.</returns>
    public static string GenerateValidAddress()
    {
        return new Faker().Address.FullAddress();
    }

    /// <summary>
    /// Generate a valid Address 
    /// </summary>
    /// <returns>An invalid phone number.</returns>
    public static string GenerateValidCity()
    {
        return new Faker().Address.City();
    }

    /// <summary>
    /// Generate a valid Address 
    /// </summary>
    /// <returns>An invalid phone number.</returns>
    public static string GenerateValidState()
    {
        return new Faker().Address.StateAbbr();
    }


}
