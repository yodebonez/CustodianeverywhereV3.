using Custodian.Life.Api.Services.PolicyServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Custodian.Life.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("policies")]
        public async Task<IActionResult> Policy()
        {
            var model = await _mediator.Send(new GetPolicyQuery { PolicyNumber = "3451000" });

            return Ok(model);
        }
    }
}