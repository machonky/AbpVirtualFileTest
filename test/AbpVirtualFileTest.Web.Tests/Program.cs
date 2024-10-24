using Microsoft.AspNetCore.Builder;
using AbpVirtualFileTest;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AbpVirtualFileTestWebTestModule>();

public partial class Program
{
}
