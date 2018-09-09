using BeerService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerService.Data
{
    internal interface IBeerContext
    {
        DbSet<Beer> Beers { get; }

        int SaveChanges();
    }
}
