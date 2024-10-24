using Volo.Abp.Modularity;

namespace AbpVirtualFileTest;

[DependsOn(
    typeof(AbpVirtualFileTestDomainModule),
    typeof(AbpVirtualFileTestTestBaseModule)
)]
public class AbpVirtualFileTestDomainTestModule : AbpModule
{

}
