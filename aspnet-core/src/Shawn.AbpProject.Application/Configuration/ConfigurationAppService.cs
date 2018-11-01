using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Shawn.AbpProject.Configuration.Dto;

namespace Shawn.AbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
