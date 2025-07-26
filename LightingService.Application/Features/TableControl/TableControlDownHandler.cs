using LightingService.Application.Common.Interfaces;
using MediatR;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlDownHandler : IRequestHandler<TableControlDownRequest, TableControlDownResponse>
    {
        private readonly ITableMotorService _motorService;

        public TableControlDownHandler(ITableMotorService motorService)
        {
            _motorService = motorService;
        }

        public async Task<TableControlDownResponse> Handle(TableControlDownRequest request, CancellationToken cancellationToken)
        {
            await _motorService.MoveDownAsync(request.Speed);

            return new TableControlDownResponse();
        }
    }
}
