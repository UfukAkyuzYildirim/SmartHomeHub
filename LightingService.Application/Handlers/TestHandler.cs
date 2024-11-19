using LightingService.Application.Requests;
using LightingService.Application.Responses;
using LightingService.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Handlers
{
    public class TestHandler : IRequestHandler<TestRequest, TestResponse>
    {
        //Task<TestResponse> IRequestHandler<TestRequest, TestResponse>.Handle(TestRequest request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
        private readonly ITestRepository _testRepository;
        public TestHandler(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public async Task<TestResponse> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            var testEntity = await _testRepository.GetTestDataAsync(request.Id);
            return new TestResponse
            {
                Id = 1,
                Data = "testEntity.Data"
            };
        }
    }
}
