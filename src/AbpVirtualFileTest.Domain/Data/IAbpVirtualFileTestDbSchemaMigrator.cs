using System.Threading.Tasks;

namespace AbpVirtualFileTest.Data;

public interface IAbpVirtualFileTestDbSchemaMigrator
{
    Task MigrateAsync();
}
