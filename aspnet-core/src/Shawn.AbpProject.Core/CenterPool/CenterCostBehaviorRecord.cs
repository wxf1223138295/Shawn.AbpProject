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

        public decimal _money { get;private set; }
        public string _eventsource { get; private set; }
        public int _eventid { get; private set; }
        public string _eventversion { get; private set; }
        public string _createuser { get; private set; }
        public string _remark { get; private set; }
        public string _actionType { get; private set; }
        public int _actionId { get; private set; }
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
