using LightingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LightingService.Infrastructure.Data
{
    public class LightningServiceDbContext : DbContext
    {
        public LightningServiceDbContext(DbContextOptions<LightningServiceDbContext> options) : base(options)
        {
        }

        public DbSet<LampEntity> Lamp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
