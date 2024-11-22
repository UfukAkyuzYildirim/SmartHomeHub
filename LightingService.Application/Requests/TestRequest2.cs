using LightingService.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Requests
{
    public class TestRequest2:IRequest<TestResponse2>
    {
        public int Id { get; set; }
    }
}
