using Microsoft.Extensions.FileProviders;
using System.Collections.Concurrent;
using System;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.VirtualFileSystem;

namespace AbpVirtualFileTest.Emailing;

public class SvgIconProvider : ISvgIconProvider
{
    private readonly string vfsRootPath;
    private readonly IVirtualFileProvider fileProvider;
    private readonly ConcurrentDictionary<string, AsyncLazy<string>> cache;

    public SvgIconProvider(string vfsRootPath, IVirtualFileProvider fileProvider)
    {
        this.vfsRootPath = vfsRootPath;
        this.fileProvider = fileProvider ?? throw new ArgumentNullException(nameof(fileProvider));
        cache = new ConcurrentDictionary<string, AsyncLazy<string>>();
    }

    public virtual async Task<string> GetSvgIconAsync(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentException("Path cannot be null or whitespace.", nameof(path));
        }

        var vfsPath = Path.Combine(vfsRootPath, path);

        var value = cache.GetOrAdd(vfsPath, key =>
            new AsyncLazy<string>(() => LoadSvgAsync(key + ".svg")));

        return await value;
    }

    private async Task<string> LoadSvgAsync(string assetVirtualFilePath)
    {
        var fileInfo = fileProvider.GetFileInfo(assetVirtualFilePath);
        if (!fileInfo.Exists)
        {
            return string.Empty;
        }

        return await fileInfo.ReadAsStringAsync();
    }
}
