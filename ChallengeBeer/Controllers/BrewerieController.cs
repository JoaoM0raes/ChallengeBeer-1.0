using Microsoft.AspNetCore.Mvc;
using Model.Interfaces;
using Model.Models.Brewerie;

namespace ChallengeBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrewerieController : MainControllerBase
    {
       

        public BrewerieController()
        {
           
        }

        [HttpPost]
        public ActionResult AddNewBrewerie(BreweryVo breweryVo)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _repository.AddBrewerie(breweryVo);

        }

        [HttpDelete]
        public void DeleteBrewerie()
        {

        }


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
