using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Shawn.AbpProject.Configuration;
using Shawn.AbpProject.Web;

namespace Shawn.AbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpProjectDbContextFactory : IDesignTimeDbContextFactory<AbpProjectDbContext>
    {
        public AbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpProjectConsts.ConnectionStringName));

            return new AbpProjectDbContext(builder.Options);
        }
    }
}
