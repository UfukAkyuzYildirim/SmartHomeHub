using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LightingService.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LightningServiceDbContext>
    {
        public LightningServiceDbContext CreateDbContext(string[] args)
        {
            // Uygulamanın çalıştığı dizini temel alarak appsettings.json'u yükle
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LightingService.API"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Development.json", optional: true)
                .Build();
            // appsettings.json içindeki ConnectionStrings:DefaultConnection anahtarından bağlantı dizesini al
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // DbContextOptions kullanarak PostgreSQL bağlantısını yapılandır
            var optionsBuilder = new DbContextOptionsBuilder<LightningServiceDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            // DbContext oluştur ve döndür
            return new LightningServiceDbContext(optionsBuilder.Options);
        }
    }
}