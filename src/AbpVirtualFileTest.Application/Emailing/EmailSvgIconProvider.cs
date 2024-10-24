using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.DependencyInjection;
using Volo.Abp.VirtualFileSystem;

namespace AbpVirtualFileTest.Emailing;

public class EmailSvgIconProvider : SvgIconProvider, IEmailSvgIconProvider, ISingletonDependency
{
    public EmailSvgIconProvider(IVirtualFileProvider fileProvider)
        : base("Emailing/Assets/svgs", fileProvider)
    { }

    public override async Task<string> GetSvgIconAsync(string path)
    {
        var svgRootContent = await base.GetSvgIconAsync(path);
        var svgDoc = XDocument.Parse(svgRootContent);
        var svgElement = svgDoc.Root;
        if (svgElement != null)
        {
            svgElement.SetAttributeValue("width", "15px");
            svgElement.SetAttributeValue("height", "auto");
        }
        svgRootContent = svgDoc.ToString();
        return svgRootContent;
    }

    public async Task<string> GetActivityIcon() => await GetSvgIconAsync("solid/person-running");

    public async Task<string> GetLocationIcon() => await GetSvgIconAsync("solid/location-dot");

    public async Task<string> GetInstructorIcon() => await GetSvgIconAsync("solid/chalkboard-user");

    public async Task<string> GetDateIcon() => await GetSvgIconAsync("solid/calendar-day");

    public async Task<string> GetTimeIcon() => await GetSvgIconAsync("regular/clock");

    public async Task<string> GetTicketIcon() => await GetSvgIconAsync("solid/ticket");

    public async Task<string> GetPhoneIcon() => await GetSvgIconAsync("solid/phone");

    public async Task<string> GetHouseIcon() => await GetSvgIconAsync("solid/house");

    public async Task<string> GetCommentIcon() => await GetSvgIconAsync("solid/comment-dots");
}