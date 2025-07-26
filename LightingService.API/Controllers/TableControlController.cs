using MediatR;
using Microsoft.AspNetCore.Mvc;
using LightingService.Application.Features.TableControl;
using FluentValidation;

namespace LightingService.API.Controllers
{
    [ApiController]
    [Route("Lightning-Api/[controller]")]
    public class TableControlController:ControllerBase
    {
        private readonly IMediator _mediator;
        public TableControlController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("TableUp")]
        public async Task<IActionResult> TableUp([FromBody] TableControlUpRequest req, [FromServices] IValidator<TableControlUpRequest> validator)
        {
            var validationResult = validator.Validate(req);
            
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(req);
            return Ok(response);
        }

        [HttpPost("TableDown")]
        public async Task<IActionResult> TableDown([FromBody] TableControlDownRequest req, [FromServices] IValidator<TableControlDownRequest> validator)
        {
            var validationResult = validator.Validate(req);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(req);
            return Ok(response);
        }

        [HttpPost("TableStop")]
        public async Task<IActionResult> TableStop([FromBody] TableControlStopRequest req)
        {
            var response = await _mediator.Send(req);
            return Ok(response);
        }

    }
}
