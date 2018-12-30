using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.EntityFrameworkCore.CenterCostRepository
{
    public class CenterCostRepository : AbpProjectRepositoryBase<CenterCost>, ICenterCostRepository
    {
        public CenterCostRepository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        
    }
}
