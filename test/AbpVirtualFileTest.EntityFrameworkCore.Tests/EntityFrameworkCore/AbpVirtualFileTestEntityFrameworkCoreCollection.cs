using Xunit;

namespace AbpVirtualFileTest.EntityFrameworkCore;

[CollectionDefinition(AbpVirtualFileTestTestConsts.CollectionDefinitionName)]
public class AbpVirtualFileTestEntityFrameworkCoreCollection : ICollectionFixture<AbpVirtualFileTestEntityFrameworkCoreFixture>
{

}
