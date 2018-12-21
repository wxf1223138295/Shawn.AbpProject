using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shawn.AbpProject.CenterPool;

namespace Shawn.AbpProject
{
    class CenterCostEntityTypeConfiguration: IEntityTypeConfiguration<CenterCost>
    {
        public void Configure(EntityTypeBuilder<CenterCost> orderConfiguration)
        {
            orderConfiguration.OwnsOne(o => o.CenterCostUses.costSubjectInfos);
        }
    }
}
