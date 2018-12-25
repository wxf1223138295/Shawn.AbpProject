using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Events.Bus;
using Shawn.AbpProject.Enum;
using Shawn.AbpProject.Events;

namespace Shawn.AbpProject.CenterPool
{
    //此处是聚合根（区分字段和属性的含义）
    //属性可以直接通过code first 生成表，而字段可以通过modelBuilder.ApplyConfiguration(）在dbcontext指定属性生成
    public class CenterCost:AggregateRoot
    {
        public CenterCostBehaviorRecord _CenterCostBehaviorRecords { get; private set; }
        public CenterCostUse _CenterCostUses { get; private set; }
        public string _particularYear;
        public decimal? _currentQuota;

        protected CenterCost()
        {
            CostSubjectInfo t = new CostSubjectInfo("2", "32", "32");

            _CenterCostUses = new CenterCostUse(1,"34","34","43",CostStaus.Frozen,t);
            _CenterCostBehaviorRecords=new CenterCostBehaviorRecord();
        }
        public CenterCost(string particularYear, decimal? currentQuota=null)
        {         
            _particularYear = particularYear ?? throw new ArgumentNullException(nameof(particularYear));
            _currentQuota = currentQuota;
        }

        public void UseCenterCost(int id)
        {
            var _centerCostUsedDomainEvent = new CenterCostUsedDomainEvent(id);
            DomainEvents.Add(_centerCostUsedDomainEvent);
        }
    }
}
