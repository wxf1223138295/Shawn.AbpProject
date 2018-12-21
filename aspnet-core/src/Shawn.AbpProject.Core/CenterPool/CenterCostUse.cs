using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Shawn.AbpProject.Enum;

namespace Shawn.AbpProject.CenterPool
{
    public class CenterCostUse:Entity<int>, IAudited
    {
        public decimal _sumQuota;
        public string _orderNum;
        public string _fromPool;
        public string _targetPool;
        public CostStaus _state;

        public CostSubjectInfo costSubjectInfos;

        private IAudited _auditedImplementation;

        public CenterCostUse()
        {

        }
        public CenterCostUse(decimal sumQuota, string orderNum, string fromPool, string targetPool, CostStaus state, CostSubjectInfo CostSubjectInfo)
        {
            _sumQuota = sumQuota;
            _orderNum = orderNum ?? throw new ArgumentNullException(nameof(orderNum));
            _fromPool = fromPool ?? throw new ArgumentNullException(nameof(fromPool));
            _targetPool = targetPool ?? throw new ArgumentNullException(nameof(targetPool));
            _state = state;
        }

        public DateTime CreationTime
        {
            get => _auditedImplementation.CreationTime;
            set => _auditedImplementation.CreationTime = value;
        }

        public long? CreatorUserId
        {
            get => _auditedImplementation.CreatorUserId;
            set => _auditedImplementation.CreatorUserId = value;
        }

        public DateTime? LastModificationTime
        {
            get => _auditedImplementation.LastModificationTime;
            set => _auditedImplementation.LastModificationTime = value;
        }

        public long? LastModifierUserId
        {
            get => _auditedImplementation.LastModifierUserId;
            set => _auditedImplementation.LastModifierUserId = value;
        }

    }
}
