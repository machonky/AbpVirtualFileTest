using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using AbpVirtualFileTest.Localization;

namespace AbpVirtualFileTest.Web;

[Dependency(ReplaceServices = true)]
public class AbpVirtualFileTestBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpVirtualFileTestResource> _localizer;

    public AbpVirtualFileTestBrandingProvider(IStringLocalizer<AbpVirtualFileTestResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
