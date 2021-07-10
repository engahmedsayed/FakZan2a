using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.FakZan2a.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class FakZan2aMigrationsDbContextFactory : IDesignTimeDbContextFactory<FakZan2aMigrationsDbContext>
    {
        public FakZan2aMigrationsDbContext CreateDbContext(string[] args)
        {
            FakZan2aEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FakZan2aMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FakZan2aMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.FakZan2a.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
