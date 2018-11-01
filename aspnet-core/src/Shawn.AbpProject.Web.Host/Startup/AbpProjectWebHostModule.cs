using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.AbpProject.Configuration;

namespace Shawn.AbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpProjectWebCoreModule))]
    public class AbpProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpProjectWebHostModule).GetAssembly());
        }
    }
}
