using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Abp.Modules;
using Shawn.AbpProject;

namespace BizMasterData.Domain
{
    [DependsOn(typeof(AbpProjectCoreModule))]
    public class BizMasterDataCoreModule: AbpModule
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
