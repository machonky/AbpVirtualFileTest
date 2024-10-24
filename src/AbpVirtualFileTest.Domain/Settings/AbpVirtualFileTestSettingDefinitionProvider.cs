using Volo.Abp.Settings;

namespace AbpVirtualFileTest.Settings;

public class AbpVirtualFileTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpVirtualFileTestSettings.MySetting1));
    }
}
