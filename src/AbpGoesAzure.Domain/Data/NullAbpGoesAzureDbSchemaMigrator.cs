using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpGoesAzure.Data;

/* This is used if database provider does't define
 * IAbpGoesAzureDbSchemaMigrator implementation.
 */
public class NullAbpGoesAzureDbSchemaMigrator : IAbpGoesAzureDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
