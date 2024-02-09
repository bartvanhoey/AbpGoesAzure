using AbpGoesAzure.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpGoesAzure.Blazor;

public abstract class AbpGoesAzureComponentBase : AbpComponentBase
{
    protected AbpGoesAzureComponentBase()
    {
        LocalizationResource = typeof(AbpGoesAzureResource);
    }
}
