using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.AbpProject.Authorization;
using Shawn.AbpProject.TestApplication.Dto;
using Shawn.AbpProject.TestEntity;

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
            //初始化映射配置
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);

            //Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            //{
            //    config.CreateMap<BookDto, Book>()
            //        .ForMember(u => u.pricebook, options => options.Ignore())
            //        .ForMember(u => u.BookName, options => options.MapFrom(input => input.publisher));
            //});
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
