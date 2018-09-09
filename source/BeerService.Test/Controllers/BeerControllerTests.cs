using BeerService.Business;
using BeerService.Controllers;
using FakeItEasy;
using Xunit;

namespace BeerService.Test.Controllers
{
    public class BeerControllerTests
    {
        private readonly BeerController _beerController;
        private readonly IBeerBusiness _beerBusiness;

        public BeerControllerTests()
        {
            _beerBusiness = A.Fake<IBeerBusiness>();
            _beerController = new BeerController(_beerBusiness);
        }

        [Fact]
        public void SaveBeer_WithPositiveAmount_CallsService()
        {
            // ARRANGE
            const int amount = 500;

            // ACT
            _beerController.SaveBeer(amount);

            // ASSERT
            A.CallTo(() => _beerBusiness.SaveBeer(amount)).MustHaveHappenedOnceExactly();
        }
    }
}
