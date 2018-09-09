using BeerService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerService.Data
{
    public class BeerContext : DbContext, IBeerContext
    {
        public BeerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Beer> Beers { get; set; }
    }
}
