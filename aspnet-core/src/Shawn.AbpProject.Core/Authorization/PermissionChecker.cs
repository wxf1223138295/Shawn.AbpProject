using Abp.Authorization;
using Shawn.AbpProject.Authorization.Roles;
using Shawn.AbpProject.Authorization.Users;

namespace Shawn.AbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
