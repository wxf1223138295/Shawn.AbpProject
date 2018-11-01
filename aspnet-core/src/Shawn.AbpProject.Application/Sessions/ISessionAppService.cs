using System.Threading.Tasks;
using Abp.Application.Services;
using Shawn.AbpProject.Sessions.Dto;

namespace Shawn.AbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
