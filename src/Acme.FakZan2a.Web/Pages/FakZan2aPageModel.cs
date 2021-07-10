using Acme.FakZan2a.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.FakZan2a.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FakZan2aPageModel : AbpPageModel
    {
        protected FakZan2aPageModel()
        {
            LocalizationResourceType = typeof(FakZan2aResource);
        }
    }
}