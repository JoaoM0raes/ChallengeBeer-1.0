using Microsoft.AspNetCore.Mvc;
using Model.Interfaces;
using Model.Interfaces.ApplicationInterfaces;
using Model.Models.Brewerie;

namespace ChallengeBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrewerieController : MainControllerBase
    {
        protected IBrewerieService _service { get; set; }
        public BrewerieController(IBrewerieService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult AddNewBrewerie(BreweryVo breweryVo)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _service.AddBrewerie(breweryVo)

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
