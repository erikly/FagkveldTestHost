using BeerService.Business;
using Microsoft.AspNetCore.Mvc;

namespace BeerService.Controllers
{
    [Route("api/[controller]")]
    public class BeerController : Controller
    {
        private readonly IBeerBusiness _beerBusiness;

        public BeerController(IBeerBusiness beerBusiness)
        {
            _beerBusiness = beerBusiness;
        }

        [HttpGet]
        public string Ping()
        {
            return "test";
        }

        [HttpPost]
        public void SaveBeer(int amount)
        {
            _beerBusiness.SaveBeer(amount);
        }
    }
}
