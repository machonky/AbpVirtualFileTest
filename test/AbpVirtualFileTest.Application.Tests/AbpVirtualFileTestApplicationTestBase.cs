using Volo.Abp.Modularity;

namespace AbpVirtualFileTest;

public abstract class AbpVirtualFileTestApplicationTestBase<TStartupModule> : AbpVirtualFileTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
