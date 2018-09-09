using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BeerService.Integration.Test.Setup;
using Xunit;

namespace BeerService.Integration.Test.Controllers
{
    [Collection(TestClientCollection.CollectionName)]
    public class BeerControllerTest
    {
        private readonly HttpClient _client;

        public BeerControllerTest(TestClientFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task SaveBeer_WithGivenAmount_ReturnsSuccess()
        {
            // ARRANGE
            var data = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("amount", "500") });

            // ACT
            var response = await _client.PostAsync("api/beer", data);

            // ASSERT
            response.EnsureSuccessStatusCode();
        }
    }
}
