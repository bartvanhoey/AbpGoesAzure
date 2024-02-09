using System;
using System.Collections.Generic;
using System.Text;
using AbpGoesAzure.Localization;
using Volo.Abp.Application.Services;

namespace AbpGoesAzure;

/* Inherit your application services from this class.
 */
public abstract class AbpGoesAzureAppService : ApplicationService
{
    protected AbpGoesAzureAppService()
    {
        LocalizationResource = typeof(AbpGoesAzureResource);
    }
}
