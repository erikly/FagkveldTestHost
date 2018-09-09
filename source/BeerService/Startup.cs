using BeerService.Business;
using BeerService.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeerService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            RegisterExternalServices(services);
            services.AddScoped<IBeerContext, BeerContext>();
            services.AddTransient<IBeerBusiness, BeerBusiness>();
            services.AddMvc();
        }

        protected virtual void RegisterExternalServices(IServiceCollection services)
        {
            services.AddDbContext<BeerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BeerDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BeerContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ConfigureExternalServices(context);

            app.UseMvc();
        }

        protected virtual void ConfigureExternalServices(BeerContext context)
        {
        }
    }
}
