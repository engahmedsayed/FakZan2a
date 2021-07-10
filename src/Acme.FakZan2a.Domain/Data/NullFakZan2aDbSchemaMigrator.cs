using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.FakZan2a.Data
{
    /* This is used if database provider does't define
     * IFakZan2aDbSchemaMigrator implementation.
     */
    public class NullFakZan2aDbSchemaMigrator : IFakZan2aDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}