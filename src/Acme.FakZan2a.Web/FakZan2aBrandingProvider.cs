using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.FakZan2a.Web
{
    [Dependency(ReplaceServices = true)]
    public class FakZan2aBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FakZan2a";
    }
}
