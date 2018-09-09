//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.TestHost;

//using Xunit;

//namespace BeerService.Integration.Test.Controllers
//{
//    public class NaiveBeerControllerTests
//    {
//        [Fact]
//        public async Task SaveBeer_WithGivenAmount_ReturnsSuccess()
//        {
//            // ARRANGE
//            var server = new TestServer(new WebHostBuilder().UseStartup<TestStartup>());
//            var client = server.CreateClient();
//            var data = new FormUrlEncodedContent(new[]{new KeyValuePair<string, string>("amount", "500") });

//            // ACT
//            var response = await client.PostAsync("api/beer", data);

//            // ASSERT
//            response.EnsureSuccessStatusCode();
//        }
//    }
//}
