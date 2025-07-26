using MediatR;
using LightingService.Application.Common.Interfaces;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlStopHandler : IRequestHandler<TableControlStopRequest, TableControlStopResponse>
    {
        private readonly ITableMotorService _motorService;
        public TableControlStopHandler(ITableMotorService motorService)
        {
            _motorService = motorService;
        }
        public async Task<TableControlStopResponse> Handle(TableControlStopRequest request, CancellationToken cancellationToken)
        {
            await _motorService.StopAsync();
            return new TableControlStopResponse();
        }
    }
}
