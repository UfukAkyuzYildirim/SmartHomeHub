using LightingService.Domain.Entities;
using LightingService.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Infrastructure.Repositories
{
    public class TestRepository : ITestRepository
    {
        //Task<TestEntity> ITestRepository.GetTestDataAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
        public async Task<TestEntity> GetTestDataAsync(int id)
        {
            return new TestEntity
            {
                Id = id,
                Data = "Test Data"
            };
        }
    }
}
