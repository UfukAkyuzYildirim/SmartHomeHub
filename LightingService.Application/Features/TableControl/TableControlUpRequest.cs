using MediatR;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlUpRequest : IRequest<TableControlUpResponse>
    {
        public int Speed { get; set; }
    }
}
