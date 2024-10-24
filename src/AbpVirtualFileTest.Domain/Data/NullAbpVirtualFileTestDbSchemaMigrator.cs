using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpVirtualFileTest.Data;

/* This is used if database provider does't define
 * IAbpVirtualFileTestDbSchemaMigrator implementation.
 */
public class NullAbpVirtualFileTestDbSchemaMigrator : IAbpVirtualFileTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
