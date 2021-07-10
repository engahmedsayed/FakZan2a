using Acme.FakZan2a.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.FakZan2a.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FakZan2aEntityFrameworkCoreDbMigrationsModule),
        typeof(FakZan2aApplicationContractsModule)
        )]
    public class FakZan2aDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
