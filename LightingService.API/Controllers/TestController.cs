using FluentValidation;
using LightingService.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LightingService.API.Controllers
{
    [ApiController]
    //[Route("api/[controller]/[action]")] //to add action name in route
    [Route("api/[controller]")]
    public class TestController:ControllerBase
    {
        private readonly IMediator _mediator;
        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetTestData([FromQuery]TestRequest req, [FromServices] IValidator<TestRequest> validator)
        {
            var validationResult = validator.Validate(req);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(req);
            return Ok(response);
        }

        [HttpGet("GetTestData2")]
        public async Task<IActionResult> GetTestData2([FromQuery]TestRequest2 req, [FromServices] IValidator<TestRequest2> validator)
        {

            var validationResult = validator.Validate(req);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(req);
            return Ok(response);
        }
    }
}
