using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shawn.AbpProject.ApplyPool;
using Shawn.AbpProject.Authorization.Roles;
using Shawn.AbpProject.Authorization.Users;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.Domain.Test1;
using Shawn.AbpProject.Domain.Test2;
using Shawn.AbpProject.MultiTenancy;
using Shawn.AbpProject.TestEntity;
using BizMasterData.Domain;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    public class AbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<BizMasterData.Domain.Person> Persons { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<CenterCost> CenterCost { get; set; }
        public virtual DbSet<ApplyCost> ApplyCost { get; set; }
        public virtual DbSet<CenterCostBehaviorRecord> CenterCostBehaviorRecord { get; set; }
        public virtual DbSet<CenterCostUse> CenterCostUse { get; set; }
        public virtual DbSet<UnitWork1> UnitWork1 { get; set; }
        public virtual DbSet<UnitWork2> UnitWork2 { get; set; }
        public AbpProjectDbContext(DbContextOptions<AbpProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BizMasterData.Domain.Person>(b => {
                b.ToTable("Person", "dbo");
            });
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
            modelBuilder.Entity<UnitWork1>(b => {
                b.ToTable("UnitWork1", "dbo");
            });
            modelBuilder.Entity<UnitWork2>(b => {
                b.ToTable("UnitWork2", "dbo");
            });
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CenterCostUseConfiguration());
            modelBuilder.ApplyConfiguration(new CenterCostEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);

        }

    }
}
