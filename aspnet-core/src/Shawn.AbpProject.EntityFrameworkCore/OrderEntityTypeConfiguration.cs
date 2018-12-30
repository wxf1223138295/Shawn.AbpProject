using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    class OrderEntityTypeConfiguration: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> orderConfiguration)
        {
            orderConfiguration.OwnsOne(o => o._PublisherInfo);

        }
    }
}