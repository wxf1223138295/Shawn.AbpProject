using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Shawn.AbpProject.MultiTenancy;

namespace Shawn.AbpProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
