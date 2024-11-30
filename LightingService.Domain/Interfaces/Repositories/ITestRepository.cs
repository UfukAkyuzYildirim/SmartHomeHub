using LightingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Domain.Interfaces.Repositories
{
    public interface ITestRepository
    {
        Task<LampEntity> GetTestDataAsync(int id);
    }
}
