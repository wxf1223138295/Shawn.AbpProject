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
        public decimal _sumQuota { get; private set; }
        public string _orderNum { get; private set; }
        public string _fromPool { get; private set; }
        public string _targetPool { get; private set; }
        public CostStaus _state { get; private set; }

        public CostSubjectInfo costSubjectInfos { get; private set; }

        private IAudited _auditedImplementation;

        protected CenterCostUse()
        {

        }

        public CenterCostUse(decimal sumQuota, string orderNum, string fromPool, string targetPool, CostStaus state, CostSubjectInfo SostSubjectInfo)
        {
            _sumQuota = sumQuota;
            _orderNum = orderNum ?? throw new ArgumentNullException(nameof(orderNum));
            _fromPool = fromPool ?? throw new ArgumentNullException(nameof(fromPool));
            _targetPool = targetPool ?? throw new ArgumentNullException(nameof(targetPool));
            _state = state;
            costSubjectInfos = SostSubjectInfo;
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
