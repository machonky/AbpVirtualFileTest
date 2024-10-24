using AbpVirtualFileTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpVirtualFileTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpVirtualFileTestController : AbpControllerBase
{
    protected AbpVirtualFileTestController()
    {
        LocalizationResource = typeof(AbpVirtualFileTestResource);
    }
}
