using AbpVirtualFileTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpVirtualFileTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpVirtualFileTestEntityFrameworkCoreModule),
    typeof(AbpVirtualFileTestApplicationContractsModule)
)]
public class AbpVirtualFileTestDbMigratorModule : AbpModule
{
}
