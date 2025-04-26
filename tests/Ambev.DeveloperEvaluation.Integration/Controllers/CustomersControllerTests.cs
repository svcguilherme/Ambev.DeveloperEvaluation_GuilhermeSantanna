using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.IntegrationTests.Controllers
{
    public class CustomersControllerTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public CustomersControllerTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetCustomer_Should_Return_200_OK_When_Id_Is_Valid()
        {
            // Arrange
            var id = Guid.NewGuid();
            var url = $"/api/customers/{id}";

            // Act
            var response = await _client.GetAsync(url);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateCustomer_Should_Return_201_Created_When_Valid_Request()
        {
            // Arrange
            var request = new
            {
                CustomerName = "Guilherme",
                CustomerCity = "Rio de Janeiro",
                CustomerState = "RJ",
                CustomerCountry = "Brazil",
                CustomerEmail = "test.customer@email.com",
                CustomerPhone = "+5511999999999",
                CustommerAddress = "Street 123"
            };

            // Act
            var response = await _client.PostAsJsonAsync("/api/customers", request);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task UpdateCustomer_Should_Return_200_OK_When_Valid_Request()
        {
            // Arrange
            var request = new
            {
                Id = Guid.NewGuid(),
                CustomerName = "Updated Customer",
                CustomerCity = "Updated City",
                CustomerState = "RJ",
                CustomerCountry = "Brazil",
                CustomerEmail = "updated.customer@email.com",
                CustomerPhone = "+5511988888888",
                CustommerAddress = "Street 456"
            };

            // Act
            var response = await _client.PutAsJsonAsync("/api/customers", request);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteCustomer_Should_Return_200_OK_When_Valid_Id()
        {
            // Arrange
            var id = Guid.NewGuid();
            var url = $"/api/customers/{id}";

            // Act
            var response = await _client.DeleteAsync(url);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
