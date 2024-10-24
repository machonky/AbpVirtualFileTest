using AbpVirtualFileTest.Emailing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace AbpVirtualFileTest.Web.Pages;

public class IndexModel : AbpVirtualFileTestPageModel
{
    public string PhoneIcon { get; private set; } = string.Empty;

    private IEmailSvgIconProvider EmailIconProvider => LazyServiceProvider.GetRequiredService<IEmailSvgIconProvider>();

    public async Task<IActionResult> OnGetAsync()
    {
        //this.PhoneIcon = await EmailIconProvider.GetPhoneIcon();

        return Page();
    }
}
