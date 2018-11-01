using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Shawn.AbpProject.Controllers
{
    public abstract class AbpProjectControllerBase: AbpController
    {
        protected AbpProjectControllerBase()
        {
            LocalizationSourceName = AbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
