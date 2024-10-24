using System.Collections.Generic;

namespace AbpVirtualFileTest.Emailing;

public interface IIconManifestGenerator
{
    void BeginRecording();
    void EndRecording();
    IEnumerable<(string ContentId, string IconPath)> GetIconPaths();
}
