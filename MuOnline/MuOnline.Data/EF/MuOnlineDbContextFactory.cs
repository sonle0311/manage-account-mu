using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MuOnline.Database.EF
{
    public class MuOnlineDbContextFactory : IDesignTimeDbContextFactory<MuOnlineDbContext>
    {
        public MuOnlineDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MuOnlineDb");

            var optionsBuilder = new DbContextOptionsBuilder<MuOnlineDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MuOnlineDbContext(optionsBuilder.Options);
        }
    }
}
