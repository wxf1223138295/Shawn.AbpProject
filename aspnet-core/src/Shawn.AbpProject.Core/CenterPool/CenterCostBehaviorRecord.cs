using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Shawn.AbpProject.CenterPool
{
    public class CenterCostBehaviorRecord : Entity<int>, IAudited
    {
        public CenterCostBehaviorRecord()
        {

        }
        public CenterCostBehaviorRecord(DateTime creationTime, decimal money, string eventsource, int eventid, string eventversion, string createuser, string remark, string actionType, int actionId)
        {
            CreationTime = creationTime;
            _money = money;
            _eventsource = eventsource ?? throw new ArgumentNullException(nameof(eventsource));
            _eventid = eventid;
            _eventversion = eventversion ?? throw new ArgumentNullException(nameof(eventversion));
            _createuser = createuser ?? throw new ArgumentNullException(nameof(createuser));
            _remark = remark ?? throw new ArgumentNullException(nameof(remark));
            _actionType = actionType ?? throw new ArgumentNullException(nameof(actionType));
            _actionId = actionId;
        }

        public decimal _money;
        public string _eventsource;
        public int _eventid;
        public string _eventversion;
        public string _createuser;
        public string _remark;
        public string _actionType;
        public int _actionId;
        private IAudited _auditedImplementation;
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
