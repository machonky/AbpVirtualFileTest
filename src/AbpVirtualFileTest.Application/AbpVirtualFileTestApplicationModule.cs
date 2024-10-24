using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;
using System.Reflection;
using Volo.Abp.VirtualFileSystem;

namespace AbpVirtualFileTest;

[DependsOn(
    typeof(AbpVirtualFileTestDomainModule),
    typeof(AbpVirtualFileTestApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpVirtualFileSystemModule)
    )]
    public class AbpVirtualFileTestApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureAutoMapper();
        ConfigureVirtualFileSystem();
    }

    private void ConfigureAutoMapper()
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpVirtualFileTestApplicationModule>();
        });
    }

    private void ConfigureVirtualFileSystem()
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpVirtualFileTestApplicationModule>(
                baseNamespace: "AbpVirtualFileTest"
                //baseFolder: "Emailing" // Fails when /Emailing is used
                );
        });
    }
}
