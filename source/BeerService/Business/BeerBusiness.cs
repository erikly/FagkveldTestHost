using System;
using BeerService.Data;
using BeerService.Data.Models;

namespace BeerService.Business
{
    internal class BeerBusiness : IBeerBusiness
    {
        private readonly IBeerContext _beerContext;

        public BeerBusiness(IBeerContext beerContext)
        {
            _beerContext = beerContext;
        }

        public void SaveBeer(int amount)
        {
            _beerContext.Beers.Add(new Beer
            {
                AmountInMilliliters = amount, Timestamp = DateTime.UtcNow
            });
            _beerContext.SaveChanges();
        }
    }
}
