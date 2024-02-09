using Volo.Abp.Modularity;

namespace AbpGoesAzure;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpGoesAzureDomainTestBase<TStartupModule> : AbpGoesAzureTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
