using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using LoanOffers.Domain.Commands;

namespace LoanOffers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("offers/{cpf}")]
        public async Task<IActionResult> GetOfferByCpf([FromRoute]GetOfferByCpfCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
