using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.AbpProject.Authorization;

namespace Shawn.AbpProject
{
    [DependsOn(
        typeof(AbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
