using AbpVirtualFileTest.Samples;
using Xunit;

namespace AbpVirtualFileTest.EntityFrameworkCore.Domains;

[Collection(AbpVirtualFileTestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpVirtualFileTestEntityFrameworkCoreTestModule>
{

}
