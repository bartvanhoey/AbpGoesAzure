using AbpGoesAzure.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpGoesAzure.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpGoesAzureController : AbpControllerBase
{
    protected AbpGoesAzureController()
    {
        LocalizationResource = typeof(AbpGoesAzureResource);
    }
}
