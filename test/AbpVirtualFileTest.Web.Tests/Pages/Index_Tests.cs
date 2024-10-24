using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpVirtualFileTest.Pages;

[Collection(AbpVirtualFileTestTestConsts.CollectionDefinitionName)]
public class Index_Tests : AbpVirtualFileTestWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
