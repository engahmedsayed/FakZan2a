using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.FakZan2a.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.FakZan2a.EntityFrameworkCore
{
    public class EntityFrameworkCoreFakZan2aDbSchemaMigrator
        : IFakZan2aDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFakZan2aDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FakZan2aMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FakZan2aMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}