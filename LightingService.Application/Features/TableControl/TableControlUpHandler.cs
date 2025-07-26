using LightingService.Application.Common.Interfaces;
using MediatR;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlUpHandler : IRequestHandler<TableControlUpRequest, TableControlUpResponse>
    {
        private readonly ITableMotorService _motorService;

        public TableControlUpHandler(ITableMotorService motorService)
        {
            _motorService = motorService;
        }

        public async Task<TableControlUpResponse> Handle(TableControlUpRequest request, CancellationToken cancellationToken)
        {
            await _motorService.MoveUpAsync(request.Speed);

            return new TableControlUpResponse();
        }
    }
}
