using AbpVirtualFileTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpVirtualFileTest.Permissions;

public class AbpVirtualFileTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpVirtualFileTestPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpVirtualFileTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpVirtualFileTestResource>(name);
    }
}
