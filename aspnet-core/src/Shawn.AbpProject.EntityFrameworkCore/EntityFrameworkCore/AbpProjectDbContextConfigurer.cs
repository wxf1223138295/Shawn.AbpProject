using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    public static class AbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
