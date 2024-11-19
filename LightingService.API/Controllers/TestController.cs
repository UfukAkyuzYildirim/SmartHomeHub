using LightingService.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LightingService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController:ControllerBase
    {
        private readonly IMediator _mediator;
        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetTestData(int id)
        {
            var response = await _mediator.Send(new TestRequest { Id = id });
            return Ok(response);
        }
    }
}
