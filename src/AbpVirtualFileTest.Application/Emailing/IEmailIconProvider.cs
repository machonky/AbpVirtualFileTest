using System.Threading.Tasks;

namespace AbpVirtualFileTest.Emailing;

public interface IEmailIconProvider
{
    Task<string> GetActivityIcon();
    Task<string> GetLocationIcon();
    Task<string> GetInstructorIcon();
    Task<string> GetDateIcon();
    Task<string> GetTimeIcon();
    Task<string> GetTicketIcon();
    Task<string> GetPhoneIcon();
    Task<string> GetHouseIcon();
    Task<string> GetCommentIcon();
}
