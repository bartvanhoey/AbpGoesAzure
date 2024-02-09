using Volo.Abp.Modularity;

namespace AbpGoesAzure;

[DependsOn(
    typeof(AbpGoesAzureApplicationModule),
    typeof(AbpGoesAzureDomainTestModule)
)]
public class AbpGoesAzureApplicationTestModule : AbpModule
{

}
