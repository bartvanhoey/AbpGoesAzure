using Volo.Abp.Modularity;

namespace AbpGoesAzure;

public abstract class AbpGoesAzureApplicationTestBase<TStartupModule> : AbpGoesAzureTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
