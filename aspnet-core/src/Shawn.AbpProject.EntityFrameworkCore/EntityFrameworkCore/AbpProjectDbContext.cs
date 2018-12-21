using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shawn.AbpProject.ApplyPool;
using Shawn.AbpProject.Authorization.Roles;
using Shawn.AbpProject.Authorization.Users;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.MultiTenancy;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    public class AbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<CenterCost> CenterCost { get; set; }
        public virtual DbSet<ApplyCost> ApplyCost { get; set; }
        public virtual DbSet<CenterCostBehaviorRecord> CenterCostBehaviorRecord { get; set; }
        public virtual DbSet<CenterCostUse> CenterCostUse { get; set; }

        public AbpProjectDbContext(DbContextOptions<AbpProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(b => {
                b.ToTable("Book", "dbo");
            });
            modelBuilder.Entity<CenterCost>(b => {
                b.ToTable("CenterCost", "dbo");
            });
            modelBuilder.Entity<ApplyCost>(b => {
                b.ToTable("ApplyCost", "dbo");
            });
            modelBuilder.Entity<CenterCostBehaviorRecord>(b => {
                b.ToTable("CenterCostBehaviorRecord", "dbo");
            });
            modelBuilder.Entity<CenterCostUse>(b => {
                b.ToTable("CenterCostUse", "dbo");
            });
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new CenterCostEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);

        }

    }
}
