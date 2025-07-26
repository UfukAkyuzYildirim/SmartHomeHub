
using MediatR;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlDownRequest : IRequest<TableControlDownResponse>
    {
        public int Speed { get; set; }
    }
}
