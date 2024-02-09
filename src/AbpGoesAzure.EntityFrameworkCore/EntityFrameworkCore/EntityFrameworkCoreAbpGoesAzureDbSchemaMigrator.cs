using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpGoesAzure.Data;
using Volo.Abp.DependencyInjection;

namespace AbpGoesAzure.EntityFrameworkCore;

public class EntityFrameworkCoreAbpGoesAzureDbSchemaMigrator
    : IAbpGoesAzureDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpGoesAzureDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AbpGoesAzureDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpGoesAzureDbContext>()
            .Database
            .MigrateAsync();
    }
}
