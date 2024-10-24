using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.VirtualFileSystem;

namespace AbpVirtualFileTest.Emailing;

public class EmailPngIconProvider : IEmailPngIconProvider, ITransientDependency
{
    private readonly IVirtualFileProvider fileProvider;
    private readonly string vfsRootPath;
    private readonly HashSet<(string ContentId, string IconPath)> iconManifest;
    private bool isRecording;

    public EmailPngIconProvider(IVirtualFileProvider fileProvider)
    {
        this.fileProvider = fileProvider;
        this.vfsRootPath = "Emailing/Assets/png15x15";
        this.iconManifest = new HashSet<(string ContentId, string IconPath)>();
        isRecording = false;
    }

    public Task<string> GetActivityIcon() => Task.FromResult(GetPngIconAsync("solid/person-running"));

    public Task<string> GetLocationIcon() => Task.FromResult(GetPngIconAsync("solid/location-dot"));

    public Task<string> GetInstructorIcon() => Task.FromResult(GetPngIconAsync("solid/chalkboard-user"));

    public Task<string> GetDateIcon() => Task.FromResult(GetPngIconAsync("solid/calendar-day"));

    public Task<string> GetTimeIcon() => Task.FromResult(GetPngIconAsync("regular/clock"));

    public Task<string> GetTicketIcon() => Task.FromResult(GetPngIconAsync("solid/ticket"));

    public Task<string> GetPhoneIcon() => Task.FromResult(GetPngIconAsync("solid/phone"));

    public Task<string> GetHouseIcon() => Task.FromResult(GetPngIconAsync("solid/house"));

    public Task<string> GetCommentIcon() => Task.FromResult(GetPngIconAsync("solid/comment-dots"));

    public void BeginRecording()
    {
        iconManifest.Clear();
        isRecording = true;
    }

    public void EndRecording()
    {
        isRecording = false;
    }

    public IEnumerable<(string ContentId, string IconPath)> GetIconPaths()
    {
        return iconManifest;
    }

    private string GetPngIconAsync(string path)
    {
        var filePath = Path.Combine(vfsRootPath, $"{path}.png");
        string contentId = SanitizeCidPath(path);

        if (isRecording)
        {
            iconManifest.Add((contentId, filePath));
        }

        if (!fileProvider.GetFileInfo(filePath).Exists)
        {
            throw new FileNotFoundException($"Icon file not found: {filePath}");
        }

        return $"""<img src="cid:{contentId}" alt="{path}" width="15" height="15" />""";
    }

    private string SanitizeCidPath(string path) => path.Replace('/', '-');
}
