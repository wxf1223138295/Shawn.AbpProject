using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shawn.AbpProject.CenterPool;

namespace Shawn.AbpProject
{
    class CenterCostUseConfiguration:IEntityTypeConfiguration<CenterCostUse>
    {
        public void Configure(EntityTypeBuilder<CenterCostUse> orderConfiguration)
        {
            orderConfiguration.OwnsOne(o => o.costSubjectInfos);
            orderConfiguration.HasKey(o => o.Id);
        }
    }
 
}
