using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shawn.AbpProject.Authorization.Roles;
using Shawn.AbpProject.Authorization.Users;
using Shawn.AbpProject.MultiTenancy;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    public class AbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Book> Books { get; set; }
        
        public AbpProjectDbContext(DbContextOptions<AbpProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(b => {
                b.ToTable("Book", "dbo");
            });
            base.OnModelCreating(modelBuilder);

        }

    }
}
