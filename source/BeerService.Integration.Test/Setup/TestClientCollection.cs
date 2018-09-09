using Xunit;

namespace BeerService.Integration.Test.Setup
{
    [CollectionDefinition(CollectionName)]
    public class TestClientCollection : ICollectionFixture<TestClientFixture>
    {
        public const string CollectionName = "Test client collection";
    }
}
