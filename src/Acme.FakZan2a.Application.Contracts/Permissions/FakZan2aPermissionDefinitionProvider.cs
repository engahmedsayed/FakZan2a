using Acme.FakZan2a.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.FakZan2a.Permissions
{
    public class FakZan2aPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FakZan2aPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FakZan2aPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FakZan2aResource>(name);
        }
    }
}
