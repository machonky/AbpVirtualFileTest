using System.Threading.Tasks;

namespace AbpVirtualFileTest.Emailing;

public interface IEmailSvgIconProvider : IEmailIconProvider
{
    Task<string> GetSvgIconAsync(string path);
}
