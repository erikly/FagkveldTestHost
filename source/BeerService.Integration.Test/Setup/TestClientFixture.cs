using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.Sqlite;

namespace BeerService.Integration.Test.Setup
{
    public class TestClientFixture : IDisposable
    {
        private readonly TestServer _server;
        private readonly SqliteConnection _connection;
        public TestClientFixture()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            TestStartup.Connection = _connection;
            _server = new TestServer(new WebHostBuilder().UseStartup<TestStartup>());
            Client = _server.CreateClient();
        }

        public HttpClient Client { get; }

        public void Dispose()
        {
            _server.Dispose();
            Client.Dispose();
            _connection.Close();
        }
    }
}
