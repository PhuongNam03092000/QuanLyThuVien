using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence
{
    public class QLTVDbContextFactory : IDesignTimeDbContextFactory<QLTVDbContext>
    {
        public QLTVDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            
            var connectionString = configuration.GetConnectionString("QuanLyThuVienDB");
            var optionsBuilder = new DbContextOptionsBuilder<QLTVDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new QLTVDbContext(optionsBuilder.Options);
        }
    }
}