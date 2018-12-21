using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus.Handlers;
using Castle.Core.Logging;
using Shawn.AbpProject.ApplyPool;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.Events;

namespace Shawn.AbpProject.DomainEventHandlers
{
    public class CenterCostUsedDomainEventHandler : IAsyncEventHandler<CenterCostUsedDomainEvent>
    {
        public ILogger Logger { get; set; }
        public ICenterCostRepository _CenterCostRepository;
        public IApplyPoolRepository _ApplyPoolRepository;

        public CenterCostUsedDomainEventHandler(ILogger logger, ICenterCostRepository CenterCostRepository, IApplyPoolRepository ApplyPoolRepository)
        {
            Logger = logger;
            _CenterCostRepository = CenterCostRepository;
            _ApplyPoolRepository=ApplyPoolRepository;
        }

        public async Task HandleEventAsync(CenterCostUsedDomainEvent eventData)
        {
            Logger.Info($"触发中央池使用的领域事件");
            var entity=new ApplyCost(eventData._id.ToString(),400);
            _ApplyPoolRepository.InsertAsync(entity);
            //todo 若有集成事件可以在此发送
        }
    }
}
