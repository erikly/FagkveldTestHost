using System.Collections.Generic;
using BeerService.Data;
using BeerService.Data.Models;
using FakeItEasy;

namespace BeerService.Test.Data.Fakers
{
    internal class ContextFaker
    {
        public List<Beer> Beers = new List<Beer>();

        public IBeerContext FakeContext { get; }

        public ContextFaker()
        {
            FakeContext = A.Fake<IBeerContext>();
            A.CallTo(() => FakeContext.Beers).Returns(FakerExtensions.ListFaker<Beer>.GetFake(Beers));
        }
        
    }
}
