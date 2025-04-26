
using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.IntegrationTests.Controllers
{
    public class PurchasesControllerTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public PurchasesControllerTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetPurchase_Should_Return_200_OK_When_Id_Is_Valid()
        {
            var id = Guid.NewGuid();
            var url = $"/api/purchases/{id}";
            var response = await _client.GetAsync(url);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreatePurchase_Should_Return_201_Created_When_Valid_Request()
        {
            var request = new
            {
                CustomerId = Guid.NewGuid(),
                BranchName = "Test Branch",
                TotalPurchase = 500,
                PurchaseDate = DateTime.UtcNow
            };
            var response = await _client.PostAsJsonAsync("/api/purchases", request);
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task UpdatePurchase_Should_Return_200_OK_When_Valid_Request()
        {
            var request = new
            {
                Id = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
                BranchName = "Updated Branch",
                TotalPurchase = 1000,
                PurchaseDate = DateTime.UtcNow
            };
            var response = await _client.PutAsJsonAsync("/api/purchases", request);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeletePurchase_Should_Return_200_OK_When_Valid_Id()
        {
            var id = Guid.NewGuid();
            var url = $"/api/purchases/{id}";
            var response = await _client.DeleteAsync(url);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
