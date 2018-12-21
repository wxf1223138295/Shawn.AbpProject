using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Abp.Events.Bus;
using Shawn.AbpProject.CenterPool;

namespace Shawn.AbpProject.Commands
{
    public class UseCenterPoolCostCommand:EventData
    {
        public UseCenterPoolCostCommand(string particularYear, decimal currentQuota, CenterCostUse centerCostUses, CenterCostBehaviorRecord centerCostBehaviorRecords, CostSubjectInfo costSubjectInfo)
        {
            _particularYear = particularYear;
            _currentQuota = currentQuota;
            CenterCostUses = centerCostUses;
            CenterCostBehaviorRecords = centerCostBehaviorRecords;
            CostSubjectInfo = costSubjectInfo;
        }

        [DataMember]
        public string _particularYear { get; private set; }
        [DataMember]
        public decimal _currentQuota { get; private set; }
        [DataMember]
        public CenterCostUse CenterCostUses { get; private set; }
        [DataMember]
        public CenterCostBehaviorRecord CenterCostBehaviorRecords { get; private set; }
        [DataMember]
        public CostSubjectInfo CostSubjectInfo { get; private set; }

    }
}
