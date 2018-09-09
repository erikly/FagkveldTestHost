using System;
using BeerService.Business;
using BeerService.Data;
using BeerService.Data.Models;
using BeerService.Test.Data.Fakers;
using FakeItEasy;
using Xunit;

namespace BeerService.Test.Business
{
    public class BeerBusinessTests
    {
        private readonly BeerBusiness _beerBusiness;
        private readonly IBeerContext _beerContext;

        public BeerBusinessTests()
        {
            _beerContext = new ContextFaker().FakeContext;
            _beerBusiness = new BeerBusiness(_beerContext);
        }

        [Fact]
        public void SaveBeer_WithGivenAmout_SavesToContext()
        {
            // ARRANGE
            const int amount = 500;

            // ACT
            _beerBusiness.SaveBeer(amount);

            // ASSERT
            A.CallTo(() =>
                _beerContext.Beers.Add(A<Beer>.That.Matches(b =>
                    b.AmountInMilliliters == amount && b.Timestamp != default(DateTime)))).MustHaveHappenedOnceExactly()
                    .Then(
                A.CallTo(() => _beerContext.SaveChanges()).MustHaveHappenedOnceExactly());
        }
    }
}
