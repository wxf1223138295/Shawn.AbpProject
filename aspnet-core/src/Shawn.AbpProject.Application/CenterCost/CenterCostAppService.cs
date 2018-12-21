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
    public class CenterCostAppService:AbpProjectAppServiceBase, ICenterCostAppService
    {
        private readonly ICenterCostAppService _CenterCostRepository;
        private readonly IMapper _mapper;

        public IEventBus EventBus { get; set; }


        public CenterCostAppService(ICenterCostAppService CenterCostRepository, IMapper mapper, IEventBus eventBus)
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
