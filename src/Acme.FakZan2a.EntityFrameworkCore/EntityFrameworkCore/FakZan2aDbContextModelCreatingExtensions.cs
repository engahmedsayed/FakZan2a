using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.FakZan2a.EntityFrameworkCore
{
    public static class FakZan2aDbContextModelCreatingExtensions
    {
        public static void ConfigureFakZan2a(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FakZan2aConsts.DbTablePrefix + "YourEntities", FakZan2aConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}