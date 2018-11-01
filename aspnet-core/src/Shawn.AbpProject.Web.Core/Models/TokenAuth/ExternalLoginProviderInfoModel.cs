using Abp.AutoMapper;
using Shawn.AbpProject.Authentication.External;

namespace Shawn.AbpProject.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
