using Volo.Abp.Modularity;

namespace AbpGoesAzure;

[DependsOn(
    typeof(AbpGoesAzureDomainModule),
    typeof(AbpGoesAzureTestBaseModule)
)]
public class AbpGoesAzureDomainTestModule : AbpModule
{

}
