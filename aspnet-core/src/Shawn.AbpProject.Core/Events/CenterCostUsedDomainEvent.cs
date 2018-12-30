using System;
using System.Collections.Generic;
using System.Text;
using Abp.Events.Bus;
using Shawn.AbpProject.CenterPool;

namespace Shawn.AbpProject.Events
{
    public class CenterCostUsedDomainEvent:EventData
    {
        public int _id { get; }
        public CenterCostUsedDomainEvent(int id)
        {
            _id = id;
        }
    }
}
