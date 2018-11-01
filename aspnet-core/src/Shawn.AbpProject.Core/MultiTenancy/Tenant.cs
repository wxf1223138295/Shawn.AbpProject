using Abp.MultiTenancy;
using Shawn.AbpProject.Authorization.Users;

namespace Shawn.AbpProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
