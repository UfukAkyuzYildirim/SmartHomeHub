using LightingService.Application.Requests;
using LightingService.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Handlers
{
    public class Test2Handler : IRequestHandler<TestRequest2, TestResponse2>
    {
        private readonly IMediator _mediator;
        public Test2Handler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TestResponse2> Handle(TestRequest2 request, CancellationToken cancellationToken)
        {
            return new TestResponse2
            {
                Id = request.Id,
                Data = "Test2"
            };
        }
    }
}
