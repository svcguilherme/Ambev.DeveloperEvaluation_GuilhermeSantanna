using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.IntegrationTests.Controllers
{
    public class ProductsControllerTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public ProductsControllerTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetProduct_Should_Return_200_OK_When_Id_Is_Valid()
        {
            var id = Guid.NewGuid();
            var url = $"/api/products/{id}";

            var response = await _client.GetAsync(url);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateProduct_Should_Return_201_Created_When_Valid_Request()
        {
            var request = new
            {
                ProductName = "Test Product",
                Description = "Description of product",
                Price = 100.50,
                CodeBar = "1234567890123"
            };

            var response = await _client.PostAsJsonAsync("/api/products", request);

            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task UpdateProduct_Should_Return_200_OK_When_Valid_Request()
        {
            var request = new
            {
                Id = Guid.NewGuid(),
                ProductName = "Updated Product",
                Description = "Updated description",
                Price = 150.75,
                CodeBar = "9876543210987"
            };

            var response = await _client.PutAsJsonAsync("/api/products", request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteProduct_Should_Return_200_OK_When_Valid_Id()
        {
            var id = Guid.NewGuid();
            var url = $"/api/products/{id}";

            var response = await _client.DeleteAsync(url);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
