using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Abp;
using Abp.Modules;
using Shawn.AbpProject;

namespace BizMasterData.Application
{
    [DependsOn(typeof(AbpProjectApplicationModule))]
    public class BizMasterDataApplicationModule: AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

        }
        public override void Initialize()
        {
            
        }

        public override void PostInitialize()
        {

        }
        public override void Shutdown()
        {

        }
    }
}
