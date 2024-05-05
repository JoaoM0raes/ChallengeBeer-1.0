using Microsoft.AspNetCore.Mvc;
using Model.EndpointResponses;
using Model.Interfaces;
using Model.Interfaces.ApplicationInterfaces;
using Model.Models.Brewerie;
using System.ComponentModel.DataAnnotations;
using System.Net;

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

            if (_service.AddBrewerie(breweryVo).Status == TaskStatus.Faulted)
            {
                _errors.Add("An internal error ocurred");
                return CustomResponse(HttpStatusCode.InternalServerError);
            }

            return CustomResponse(new ReturnOk { message = " New Brewerie added with success !!", sucess = true });
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBrewerie([Required] Guid id)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            if (_service.DeleteBrewerie(id).Status == TaskStatus.Faulted)
            {
                _errors.Add("An internal error ocurred");
                return CustomResponse(HttpStatusCode.InternalServerError);
            }

            return CustomResponse(new ReturnOk { message = $"Brewerie with id: {id} deleted with success !!", sucess = true });
        }


        [HttpPost("{id}")]
        public void AddNewBeer(Guid id)
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
