using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;
using System.Text;

namespace ChallengeBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainControllerBase : ControllerBase
    {
        public List<string> _errors { get; set; }

        protected ActionResult CustomResponse(object result = null, HttpStatusCode? ResponseCode = null)
        {
            if (!_errors.Any())
                return Ok(result);

            return ValidateErrorHttpStatus(ResponseCode);
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(x => x.Errors);

            if (errors.Any())
                foreach (var error in errors)
                    _errors.Add(error.ErrorMessage);

            return CustomResponse();
        }

        protected void AddError(string errorMessage)
        {
            _errors.Add(errorMessage);
        }

        protected ActionResult ValidateErrorHttpStatus(HttpStatusCode? ResponseCode)
        {
            int statusCode = (int)ResponseCode;

            string TitleMessage = "";

            switch (statusCode)
            {
                case 500:
                    TitleMessage = "Internal Error";
                    break;
                case 400:
                    TitleMessage = "Not Found";
                    break;
            }

            return Problem(AppendErrorsMessage(), null, statusCode, TitleMessage);
        }

        protected string AppendErrorsMessage()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var error in _errors)
                builder.Append(error + ";");

            return builder.ToString();
        }
    }
}
