using System;
using BeerService.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeerService.Integration.Test
{
    internal class TestStartup : Startup
    {
        internal static SqliteConnection Connection;

        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void RegisterExternalServices(IServiceCollection services)
        {
            services.AddDbContext<BeerContext>(options => options.UseSqlite(Connection));
        }

        // NAIVE!
        //protected override void RegisterExternalServices(IServiceCollection services)
        //{
        //    var connection = new SqliteConnection("Datasource=:memory:");
        //    connection.Open();
        //    services.AddDbContext<BeerContext>(options => options.UseSqlite(connection));
        //}

        protected override void ConfigureExternalServices(BeerContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
