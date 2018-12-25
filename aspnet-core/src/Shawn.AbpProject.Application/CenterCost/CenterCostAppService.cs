using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus;
using AutoMapper;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.Commands;
using Shawn.AbpProject.Enum;

namespace Shawn.AbpProject.CenterCost
{
    //应用层
    //请按 name+AppService命名（swagger ui继承，写到应用层可以直接测试） 约定大于配置 继承 AbpProjectAppServiceBase，
    //已实现依赖注入
    public class CenterCostAppService:AbpProjectAppServiceBase, ICenterCostAppService
    {
        private readonly ICenterCostRepository _CenterCostRepository;
        //automap  特定映射请在配置类配置  我已集成  CustomDtoMapper.cs      
        private readonly IMapper _mapper;
        //abp自带的内存级别事件总线
        public IEventBus EventBus { get; set; }


        public CenterCostAppService(ICenterCostRepository CenterCostRepository, IMapper mapper, IEventBus eventBus)
        {
            _CenterCostRepository = CenterCostRepository;
            _mapper = mapper;
            EventBus = eventBus;
        }

        public void usecenterpool()
        {
            CostSubjectInfo info=new CostSubjectInfo("23","232","434");
            CenterCostUse entity1 = new CenterCostUse(100,"23","34","34",CostStaus.Frozen,info);
            CenterCostBehaviorRecord record=new CenterCostBehaviorRecord(DateTime.Now, 11,"we",1,"34","sds","dsd","ww",3);
            var command=new UseCenterPoolCostCommand("2012",100,entity1, record,info);

            EventBus.TriggerAsync(command);
        }
    }
}
