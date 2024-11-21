using LightingService.Application.Requests;
using MediatR;
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
        public async Task<IActionResult> GetTestData(int id)
        {
            var response = await _mediator.Send(new TestRequest { Id = id });
            return Ok(response);
        }

        [HttpGet("GetTestData2")]
        public async Task<IActionResult> GetTestData2()
        {
            // Perform necessary logic here

            return BadRequest();
        }
    }
}
