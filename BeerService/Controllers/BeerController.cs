using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BeerService.Controllers
{
    [Route("api/[controller]")]
    public class BeerController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
