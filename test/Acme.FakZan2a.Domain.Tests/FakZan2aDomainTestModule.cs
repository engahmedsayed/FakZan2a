using Acme.FakZan2a.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.FakZan2a
{
    [DependsOn(
        typeof(FakZan2aEntityFrameworkCoreTestModule)
        )]
    public class FakZan2aDomainTestModule : AbpModule
    {

    }
}