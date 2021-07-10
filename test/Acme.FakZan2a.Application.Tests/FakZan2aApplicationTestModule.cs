using Volo.Abp.Modularity;

namespace Acme.FakZan2a
{
    [DependsOn(
        typeof(FakZan2aApplicationModule),
        typeof(FakZan2aDomainTestModule)
        )]
    public class FakZan2aApplicationTestModule : AbpModule
    {

    }
}