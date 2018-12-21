using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Events.Bus;
using Shawn.AbpProject.Events;

namespace Shawn.AbpProject.CenterPool
{
    public class CenterCost:AggregateRoot
    {
        
        public CenterCostBehaviorRecord CenterCostBehaviorRecords { get; private set; }
        public CenterCostUse CenterCostUses { get; private set; }
        public string _particularYear;
        public decimal _currentQuota;

      
        public CenterCost(CenterCostBehaviorRecord centerCostBehaviorRecords, CenterCostUse centerCostUses, string particularYear, decimal currentQuota)
        {
            CenterCostBehaviorRecords = centerCostBehaviorRecords ?? throw new ArgumentNullException(nameof(centerCostBehaviorRecords));
            CenterCostUses = centerCostUses ?? throw new ArgumentNullException(nameof(centerCostUses));
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
