using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpVirtualFileTest.Data;
using Volo.Abp.DependencyInjection;

namespace AbpVirtualFileTest.EntityFrameworkCore;

public class EntityFrameworkCoreAbpVirtualFileTestDbSchemaMigrator
    : IAbpVirtualFileTestDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpVirtualFileTestDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpVirtualFileTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpVirtualFileTestDbContext>()
            .Database
            .MigrateAsync();
    }
}
