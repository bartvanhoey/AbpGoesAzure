using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpGoesAzure.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpGoesAzureBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpGoesAzure";
}
