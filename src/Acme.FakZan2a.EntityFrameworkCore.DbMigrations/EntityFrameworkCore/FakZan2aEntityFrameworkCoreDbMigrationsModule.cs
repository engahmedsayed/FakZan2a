using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.FakZan2a.EntityFrameworkCore
{
    [DependsOn(
        typeof(FakZan2aEntityFrameworkCoreModule)
        )]
    public class FakZan2aEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FakZan2aMigrationsDbContext>();
        }
    }
}
