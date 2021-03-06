﻿using System;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using BizMasterData.Application;
using Shawn.AbpProject.Authentication.JwtBearer;
using Shawn.AbpProject.Configuration;
using Shawn.AbpProject.EntityFrameworkCore;

namespace Shawn.AbpProject
{
    [DependsOn(
         //typeof(AbpProjectApplicationModule),
        typeof(BizMasterDataApplicationModule),
         typeof(AbpProjectEntityFrameworkModule),
         typeof(AbpAspNetCoreModule)
        ,typeof(AbpAspNetCoreSignalRModule)
     )]
    public class AbpProjectWebCoreModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpProjectWebCoreModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpProjectConsts.ConnectionStringName
            );

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Modules.AbpAspNetCore()
                 .CreateControllersForAppServices(
                     typeof(AbpProjectApplicationModule).GetAssembly()
                 );
            //向swagger中动态生成api测试
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BizMasterDataApplicationModule).GetAssembly()
                );

            ConfigureTokenAuth();
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            tokenAuthConfig.SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.SigningCredentials = new SigningCredentials(tokenAuthConfig.SecurityKey, SecurityAlgorithms.HmacSha256);
            tokenAuthConfig.Expiration = TimeSpan.FromDays(1);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpProjectWebCoreModule).GetAssembly());
        }
    }
}
