using AbpGoesAzure.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpGoesAzure.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpGoesAzureEntityFrameworkCoreModule),
    typeof(AbpGoesAzureApplicationContractsModule)
    )]
public class AbpGoesAzureDbMigratorModule : AbpModule
{
}
