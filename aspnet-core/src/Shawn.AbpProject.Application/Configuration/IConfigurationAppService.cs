using System.Threading.Tasks;
using Shawn.AbpProject.Configuration.Dto;

namespace Shawn.AbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
