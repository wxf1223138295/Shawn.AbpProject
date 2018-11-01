using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shawn.AbpProject.Authorization.Roles;
using Shawn.AbpProject.Authorization.Users;
using Shawn.AbpProject.MultiTenancy;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    public class AbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpProjectDbContext(DbContextOptions<AbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
