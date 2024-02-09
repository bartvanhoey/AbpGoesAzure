using System.Threading.Tasks;

namespace AbpGoesAzure.Data;

public interface IAbpGoesAzureDbSchemaMigrator
{
    Task MigrateAsync();
}
