using AbpVirtualFileTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpVirtualFileTest.Web.Pages;

public abstract class AbpVirtualFileTestPageModel : AbpPageModel
{
    protected AbpVirtualFileTestPageModel()
    {
        LocalizationResourceType = typeof(AbpVirtualFileTestResource);
    }
}
