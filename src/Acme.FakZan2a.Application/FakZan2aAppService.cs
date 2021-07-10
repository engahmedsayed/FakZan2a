using System;
using System.Collections.Generic;
using System.Text;
using Acme.FakZan2a.Localization;
using Volo.Abp.Application.Services;

namespace Acme.FakZan2a
{
    /* Inherit your application services from this class.
     */
    public abstract class FakZan2aAppService : ApplicationService
    {
        protected FakZan2aAppService()
        {
            LocalizationResource = typeof(FakZan2aResource);
        }
    }
}
