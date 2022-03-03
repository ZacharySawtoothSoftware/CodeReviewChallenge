using CodeReviewExample.BusinessLogic.Managers;
using CodeReviewExample.Client.Abstractions.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeReviewExampleProject.Services.Controllers
{
    [ApiController]
    [Route("Calculator")]
    [ApiVersion("1.0")]
    public class CalculatorController : ControllerBase
    {
        private CalculatorManager _calculatorManager;

        [HttpGet("Run")]
        public async Task<ActionResult<ResponseModel>> RunAsync(RequestModel request)
        {
            ResponseModel response = _calculatorManager.Run(request);
            return Ok(response);
        }
    }
}
