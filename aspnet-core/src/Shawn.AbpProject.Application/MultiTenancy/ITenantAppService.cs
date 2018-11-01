using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Shawn.AbpProject.MultiTenancy.Dto;

namespace Shawn.AbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
