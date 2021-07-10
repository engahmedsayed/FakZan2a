using Acme.FakZan2a.Users;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace Acme.FakZan2a.EntityFrameworkCore
{
    public static class FakZan2aEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            FakZan2aGlobalFeatureConfigurator.Configure();
            FakZan2aModuleExtensionConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {
                /* You can configure extra properties for the
                 * entities defined in the modules used by your application.
                 *
                 * This class can be used to map these extra properties to table fields in the database.
                 *
                 * USE THIS CLASS ONLY TO CONFIGURE EF CORE RELATED MAPPING.
                 * USE FakZan2aModuleExtensionConfigurator CLASS (in the Domain.Shared project)
                 * FOR A HIGH LEVEL API TO DEFINE EXTRA PROPERTIES TO ENTITIES OF THE USED MODULES
                 *
                 * Example: Map a property to a table field:

                     ObjectExtensionManager.Instance
                         .MapEfCoreProperty<IdentityUser, string>(
                             "MyProperty",
                             (entityBuilder, propertyBuilder) =>
                             {
                                 propertyBuilder.HasMaxLength(128);
                             }
                         );

                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
                 */
                ObjectExtensionManager.Instance
                .MapEfCoreProperty<IdentityUser, string>(
                    nameof(AppUser.FullNameArabic),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue("");
                        //propertyBuilder.IsRequired();
                        propertyBuilder.HasMaxLength(UserConsts.MaxFullNameArabicLength);
                    }
                ).MapEfCoreProperty<IdentityUser, string>(
                    nameof(AppUser.FullNameEnglish),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue("");
                        //propertyBuilder.IsRequired();
                        propertyBuilder.HasMaxLength(UserConsts.MaxFullNameEnglishLength);

                    }
                ).MapEfCoreProperty<IdentityUser, string>(
                    nameof(AppUser.Mobile),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue("");
                        //propertyBuilder.IsRequired();
                        propertyBuilder.HasMaxLength(UserConsts.MaxMobileNumberLength);

                    }
                ).MapEfCoreProperty<IdentityUser, string>(
                    nameof(AppUser.WhatsAppNumber),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue("");
                        //propertyBuilder.IsRequired();
                        propertyBuilder.HasMaxLength(UserConsts.MaxWhatsAppNumberLength);

                    }
                ).MapEfCoreProperty<IdentityUser, DateTime?>(
                    nameof(AppUser.DateOfBirth),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(DateTime.Now);
                       // propertyBuilder.IsRequired();

                    }
                ).MapEfCoreProperty<IdentityUser, int?>(
                    nameof(AppUser.Gender),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(1);
                        //propertyBuilder.IsRequired();

                    }
                ).MapEfCoreProperty<IdentityUser, int?>(
                    nameof(AppUser.UserType),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(1);
                       // propertyBuilder.IsRequired();

                    }
                ).MapEfCoreProperty<IdentityUser, int?>(
                    nameof(AppUser.LanguagePreference),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(1);
                        //propertyBuilder.IsRequired();

                    }
                ).MapEfCoreProperty<IdentityUser, bool?>(
                    nameof(AppUser.IsActive),
                    (entityBuilder, propertyBuilder) =>
                    {
                        propertyBuilder.HasDefaultValue(false);
                        //propertyBuilder.IsRequired();

                    }
                );

            });
        }
    }
}
