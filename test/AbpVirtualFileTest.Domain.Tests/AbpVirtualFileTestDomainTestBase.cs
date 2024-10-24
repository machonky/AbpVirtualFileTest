using Volo.Abp.Modularity;

namespace AbpVirtualFileTest;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpVirtualFileTestDomainTestBase<TStartupModule> : AbpVirtualFileTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
