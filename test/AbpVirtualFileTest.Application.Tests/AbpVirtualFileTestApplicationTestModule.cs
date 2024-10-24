using Volo.Abp.Modularity;

namespace AbpVirtualFileTest;

[DependsOn(
    typeof(AbpVirtualFileTestApplicationModule),
    typeof(AbpVirtualFileTestDomainTestModule)
)]
public class AbpVirtualFileTestApplicationTestModule : AbpModule
{

}
