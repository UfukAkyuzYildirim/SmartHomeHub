using LightingService.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Requests
{
    public class TestRequest:IRequest<TestResponse>
    {
        public int Id { get; set; }
    }
}
