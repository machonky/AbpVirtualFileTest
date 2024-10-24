using AbpVirtualFileTest.Localization;
using Volo.Abp.Application.Services;

namespace AbpVirtualFileTest;

/* Inherit your application services from this class.
 */
public abstract class AbpVirtualFileTestAppService : ApplicationService
{
    protected AbpVirtualFileTestAppService()
    {
        LocalizationResource = typeof(AbpVirtualFileTestResource);
    }
}
