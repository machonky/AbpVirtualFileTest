using System.Threading.Tasks;

namespace AbpVirtualFileTest.Emailing;

public interface ISvgIconProvider
{
    Task<string> GetSvgIconAsync(string iconPath);
}
