using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Common.Interfaces
{
    public interface ITableMotorService
    {
        Task MoveUpAsync(int speed);
        Task MoveDownAsync(int speed);
        Task StopAsync();
    }
}
