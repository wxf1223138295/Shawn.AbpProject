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
            orderConfiguration.HasKey(o => o.Id);

            orderConfiguration.Property<string>("particularYear").IsRequired(false);
            orderConfiguration.Property<decimal?>("currentQuota").IsRequired(false);

            //orderConfiguration.HasOne<CenterCostBehaviorRecord>()
            //    .WithMany()
            //    .HasForeignKey("BehaviorRecordId")
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.Restrict);
            //orderConfiguration.HasOne<CenterCostUse>()
            //    .WithMany()
            //    .HasForeignKey("CostUseId")
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
