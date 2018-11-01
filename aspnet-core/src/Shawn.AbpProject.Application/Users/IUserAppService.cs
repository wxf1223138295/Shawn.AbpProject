using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Shawn.AbpProject.Roles.Dto;
using Shawn.AbpProject.Users.Dto;

namespace Shawn.AbpProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
