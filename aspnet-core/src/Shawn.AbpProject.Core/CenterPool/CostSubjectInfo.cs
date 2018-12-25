using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Values;

namespace Shawn.AbpProject.CenterPool
{
    public class CostSubjectInfo: ValueObject<CostSubjectInfo>
    {
        public CostSubjectInfo(string subjectName, string costQuota, string costAttribute)
        {
            SubjectName = subjectName ?? throw new ArgumentNullException(nameof(subjectName));
            CostQuota = costQuota ?? throw new ArgumentNullException(nameof(costQuota));
            CostAttribute = costAttribute ?? throw new ArgumentNullException(nameof(costAttribute));
        }

        private CostSubjectInfo() { }
        public String SubjectName { get; }
        public String CostQuota { get; }
        public String CostAttribute { get; }

            
    }
}
