using Volo.Abp.Settings;

namespace Acme.FakZan2a.Settings
{
    public class FakZan2aSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FakZan2aSettings.MySetting1));
        }
    }
}
