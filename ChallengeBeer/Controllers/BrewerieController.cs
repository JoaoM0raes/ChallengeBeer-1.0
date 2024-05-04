using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrewerieController : MainControllerBase
    {

        [HttpPost]
        public void AddNewBeer()
        {

        }

        [HttpPut("{id}")]
        public void EditBeer(Guid id)
        {

        }

        [HttpDelete("{id}")]
        public void DeleteBeer(Guid id)
        {

        }
    }
}
