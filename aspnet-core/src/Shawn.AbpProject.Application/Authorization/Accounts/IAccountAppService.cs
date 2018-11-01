using System.Threading.Tasks;
using Abp.Application.Services;
using Shawn.AbpProject.Authorization.Accounts.Dto;

namespace Shawn.AbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
