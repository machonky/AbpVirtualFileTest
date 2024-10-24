using AbpVirtualFileTest.Samples;
using Xunit;

namespace AbpVirtualFileTest.EntityFrameworkCore.Applications;

[Collection(AbpVirtualFileTestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpVirtualFileTestEntityFrameworkCoreTestModule>
{

}
