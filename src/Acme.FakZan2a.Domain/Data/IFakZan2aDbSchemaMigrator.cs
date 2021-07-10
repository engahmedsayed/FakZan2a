using System.Threading.Tasks;

namespace Acme.FakZan2a.Data
{
    public interface IFakZan2aDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
