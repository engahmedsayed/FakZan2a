using Acme.FakZan2a.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.FakZan2a.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FakZan2aController : AbpController
    {
        protected FakZan2aController()
        {
            LocalizationResource = typeof(FakZan2aResource);
        }
    }
}